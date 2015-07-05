using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importaciones
using CineEvo.BL;
using CineEvo.BE;

namespace CineEvo.UI
{
    public partial class frmPrecios : Form
    {
        TipoEntradaBL objTipoEntradaBL = TipoEntradaBL.ObtenerInstancia();

        //Recibe data
        public CCine cine;
        public CFuncion funcion ;
        public CPelicula pelicula;
        public CSala sala;
        public double precio;
        public String tipo_funcion;

        public frmPrecios()
        {
            InitializeComponent();
        }

        private void frmPrecios_Load(object sender, EventArgs e)
        {
            //Cargo data
            CargarData();

            //Titulo
            this.Text = "Cine: " + cine.nombre.ToString();
                
            //Oculto lo innecesario
            //dgvFunciones.Columns[0].Visible = false;

            //Ajustar tamaño del dgv
            dgvPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Seleccionar toda la fila
            dgvPrecios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void CargarData()
        {
            IList<CTipoEntrada> entradas = objTipoEntradaBL.Listar();
            var data = from e in entradas
                       select new FuncionGridWrapperEntrada()
                       {
                           nombre = e.nombre,
                           //El precio varia dependiendo del tipo de funcion (2D,3D)
                           precio = e.precio+precio
                       };
            if (data == null)
            {
                MessageBox.Show("Error al cargar data","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvPrecios.DataSource = data.ToList();
                //Columna de cantidad
                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.HeaderText = "Cantidad";
                cmb.Name = "cmb";
                cmb.MaxDropDownItems = 4;
                cmb.Items.Add("0");
                cmb.Items.Add("1");
                cmb.Items.Add("2");
                cmb.Items.Add("3");
                cmb.Items.Add("4");
                cmb.Items.Add("5");
               
                dgvPrecios.Columns.Add(cmb);
                //Columna de total
                DataGridViewTextBoxColumn cmb2 = new DataGridViewTextBoxColumn();
                cmb2.HeaderText = "Total";
                cmb2.Name = "cmb2";
                cmb2.ReadOnly = true;
                dgvPrecios.Columns.Add(cmb2);
                                
            }
        }
        public class FuncionGridWrapperEntrada
        {
            public string nombre { get; set; }
            public double precio { get; set; }
        }
    }
}
