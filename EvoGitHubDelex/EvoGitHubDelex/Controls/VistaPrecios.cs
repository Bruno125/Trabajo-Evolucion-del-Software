using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CineEvo.BL;
using CineEvo.BE;

namespace CineEvo.UI.Controls
{
    public partial class VistaPrecios : CineEvo.UI.Controls.BaseControl
    {
        TipoEntradaBL objTipoEntradaBL = TipoEntradaBL.ObtenerInstancia();
        CCine cine;

        /*
        Llenar con data temporal
        update Funcion
        set fechaFuncion='2015-24-05 00:00:00.000'
        */

        //Pendiente
        //Recibir el tipo de pelicula seleccionada de la anterior ventana
        //Corregir doble generacion del header del panel

        //Datos recibidos
        public String tipo_funcion;


        public VistaPrecios(CCine cine, ControlListener ControlListener)
            : base(ControlListener)
        {
            InitializeComponent();
            this.cine = cine;
            //SetTitulo(cine.nombre);
            SetTitulo(tipo_funcion);
        }
        public VistaPrecios()
        {
            InitializeComponent();
            SetTitulo("Nombre del cine");
        }
        public List<FuncionGridWrapperEntrada> ObtenerData()
        {
            List<FuncionGridWrapperEntrada> GridData = new List<FuncionGridWrapperEntrada>();
            try
            {
                IList<CTipoEntrada> entradas = objTipoEntradaBL.Listar();
                var data =
                    from e in entradas
                    select new FuncionGridWrapperEntrada()
                    {
                        nombre = e.nombre,
                        //El precio varia dependiendo del tipo de funcion (2D,3D)
                        precio = e.precio
                        /*
                         * if(tipo_pelicula==1)
                         * {
                         * precio=precio*1.25;
                         * }
                         */
                    };

                GridData = data.ToList();
            }
            catch (Exception E)
            {
                return null;
            }
            return GridData;
        }

        private void VistaPrecios_Load(object sender, EventArgs e)
        {
            List<FuncionGridWrapperEntrada> Data = ObtenerData();
            if (Data != null && Data.Count > 0)
                DgvPrecios.DataSource = ObtenerData();
        }
    }

    public class FuncionGridWrapperEntrada
    {
        public string nombre { get; set; }
        public double precio { get; set; }        
    }
}
