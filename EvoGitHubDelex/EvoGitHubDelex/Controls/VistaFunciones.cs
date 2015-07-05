using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

using CineEvo.BL;
using CineEvo.BE;

namespace CineEvo.UI.Controls
{
    public partial class VistaFunciones : CineEvo.UI.Controls.BaseControl
    {
        FuncionBL objFuncionBL = FuncionBL.ObtenerInstancia();
        PeliculaBL objPeliculaBL = PeliculaBL.ObtenerInstancia();
        TipoFuncionBL objTipoFuncionBL = TipoFuncionBL.ObtenerInstancia();
        SalaBL objSalaBL = SalaBL.ObtenerInstancia();
        CCine cine;

        public VistaFunciones(CCine cine, ControlListener ControlListener)
            : base(ControlListener)
        {
            InitializeComponent();
            this.cine = cine;
            SetTitulo(cine.nombre);
        }

        public VistaFunciones()
        {
            InitializeComponent();
            SetTitulo("Nombre del cine");
        }


        public List<FuncionGridWrapper> ObtenerData()
        {
            List<FuncionGridWrapper> GridData = new List<FuncionGridWrapper>();
            try
            {
                GridData = (from f in FuncionBL.ObtenerInstancia().ListarFromCine(cine.idCine)
                            select new FuncionGridWrapper()
                            {
                                horario = f.horario,
                                id_funcion = f.id_funcion,
                                NombrePelicula = f.NombrePelicula,
                                sala = f.Sala.nombre,
                                tipo_funcion = f.tipo_funcion
                            }).ToList();
            }
            catch (Exception)
            {
                return null;
            }
            return GridData;
        }

        private void VistaFunciones_Load(object sender, EventArgs e)
        {
            List<FuncionGridWrapper> Data = ObtenerData();
            if (Data != null && Data.Count > 0)
                DgvFunciones.DataSource = ObtenerData();
            //else
            //{
            //    MessageBox.Show("No hay funciones disponibles para este local el día de hoy");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SPRINT 1
                VistaPrecios VistaPrecios = new VistaPrecios(cine, ControlListener);
                VistaPrecios.tipo_funcion = DgvFunciones.SelectedRows[0].Cells[3].Value.ToString();
                //SI LO TRAE :D
                MostrarUserControl(VistaPrecios);

                //frmPrecios frmP = new frmPrecios();
                //frmP.Show();



                //--------------CONTINUAR
                /*
                int SelectedIdFuncion =
                    (DgvFunciones.SelectedRows[0].DataBoundItem as FuncionGridWrapper).id_funcion;
                MessageBox.Show("Id_funcion: " + SelectedIdFuncion);
                 */
            }
            catch (Exception E)
            {
                MessageBox.Show("Selecciona una funcion",E.Message);
            }
        }
        UserControl currentControl;
        public void MostrarUserControl(UserControl control)
        {
            currentControl = control;
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.Location = new System.Drawing.Point(0, 0);
            control.TabIndex = 15;
            this.Controls.Add(control);
            this.Controls.SetChildIndex(control, 0);
        }
    }


    public class FuncionGridWrapper
    {
        public int id_funcion { get; set; }
        public string NombrePelicula { get; set; }
        public DateTime horario { get; set; }
        public string tipo_funcion { get; set; }
        public string sala { get; set; }
    }    
}
