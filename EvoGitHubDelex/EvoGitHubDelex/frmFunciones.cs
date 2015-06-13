using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CineEvo.BL;
using CineEvo.DataModel;

namespace CineEvo.UI
{
    public partial class frmFunciones : Form
    {
        //Metodos
        FuncionBL objFuncionBL = FuncionBL.ObtenerInstancia();
        PeliculaBL objPeliculaBL = PeliculaBL.ObtenerInstancia();
        TipoFuncionBL objTipoFuncionBL = TipoFuncionBL.ObtenerInstancia();
        SalaBL objSalaBL = SalaBL.ObtenerInstancia();        

        //Atributos
        public Cine cine;

        /*
         * Actualizar fechas
         * update Funcion
         * set fechaFuncion=GETDATE()
         */

        public frmFunciones()
        {
            InitializeComponent();            
        }

        public void CargarData()
        {
            
            IList<Funcion> funciones = objFuncionBL.ObtenerFunciones();
            IList<Pelicula> peliculas = objPeliculaBL.ObtenerPeliculas();
            IList<TipoFuncion> tipos_funcion = objTipoFuncionBL.ObtenerTiposFuncion();
            IList<Sala> salas = objSalaBL.ObtenerSalas();
            DateTime now = DateTime.Now;
            var data =
                from p in peliculas
                join f in funciones on p.idPelicula equals f.idPelicula
                into pelicula_funcion
                from pf in pelicula_funcion
                join t in tipos_funcion on pf.idTipoFuncion equals t.idTipoFuncion
                into pft
                join s in salas on pf.idSala equals s.idSala
                where (pf.fechaFuncion.Date == now.Date
                        && DateTime.Compare(now,pf.fechaFuncion)<0
                        && s.idCine == cine.idCine)
                select new FuncionGridWrapper()
                {
                    //-----Capturo-----
                    id_funcion = pf.idFuncion,
                    id_pelicula = p.idPelicula,
                    id_sala = s.idSala,
                    tipo_funcion = pf.TipoFuncion.nombre,
                    precio = pf.TipoFuncion.precio,
                    //-----Capturo-----
                    NombrePelicula = pf.Pelicula.titulo,
                    horario = pf.fechaFuncion,
                    sala = s.nombre
                };
            if (data == null)
            {
                MessageBox.Show("No existen funciones","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvFunciones.DataSource = data.ToList();
            }
            
        }

        public class FuncionGridWrapper
        {            
            //Orde de los atributos
            public int id_funcion { get; set; }//0
            public int id_pelicula { get; set; }//1
            public int id_sala { get; set; }//2     
            public double precio { get; set; }//3
            
            public string NombrePelicula { get; set; }//4
            public DateTime horario { get; set; }//5
            public string tipo_funcion { get; set; }//6
            public string sala { get; set; }//7
        }

        private void frmFunciones_Load(object sender, EventArgs e)
        {
            //Cargo data
            CargarData();

            //Titulo
            this.Text = "Cine: " + cine.nombre.ToString();

            //Oculto lo innecesario
            dgvFunciones.Columns[0].Visible = false;
            dgvFunciones.Columns[1].Visible = false;
            dgvFunciones.Columns[2].Visible = false;
            dgvFunciones.Columns[3].Visible = false;

            //Ajustar tamaño del dgv
            dgvFunciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Seleccionar toda la fila
            dgvFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Data seleccionada
            int id_funcion=Int32.Parse(dgvFunciones.SelectedRows[0].Cells[0].Value.ToString());
            int id_pelicula=Int32.Parse(dgvFunciones.SelectedRows[0].Cells[1].Value.ToString());
            int id_sala=Int32.Parse(dgvFunciones.SelectedRows[0].Cells[2].Value.ToString());
            double precio = Double.Parse(dgvFunciones.SelectedRows[0].Cells[3].Value.ToString());
            string tipo_funcion = dgvFunciones.SelectedRows[0].Cells[6].Value.ToString();
            
            //-----Preparo la data-----
            Funcion funcion = objFuncionBL.ObtenerFuncion(id_funcion);//Testing
            Pelicula pelicula = objPeliculaBL.ObtenerPelicula(id_pelicula);//Testing
            Sala sala = objSalaBL.ObtenerSala(id_sala);//Testing

            //-----Creo el formulario-----
            frmPrecios frmP = new frmPrecios();

            //-----Envio-----
            frmP.funcion = funcion;
            frmP.pelicula = pelicula;
            frmP.sala = sala;
            frmP.precio = precio;
            frmP.tipo_funcion = tipo_funcion;
            frmP.cine = cine;

            //-----Muestro el formulario-----
            frmP.Show();
        }
    }
}
