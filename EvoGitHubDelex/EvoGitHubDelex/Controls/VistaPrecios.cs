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
using CineEvo.DataModel;

namespace CineEvo.UI.Controls
{
    public partial class VistaPrecios : CineEvo.UI.Controls.BaseControl
    {
        TipoEntradaBL objTipoEntradaBL = TipoEntradaBL.ObtenerInstancia();
        Cine cine;

        public VistaPrecios(Cine cine, ControlListener ControlListener)
            : base(ControlListener)
        {
            InitializeComponent();
            this.cine = cine;
            SetTitulo(cine.nombre);
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
                IList<TipoEntrada> entradas = objTipoEntradaBL.ObtenerTiposEntrada();
                var data =
                    from e in entradas
                    select new FuncionGridWrapperEntrada()
                    {
                        nombre = e.nombre,
                        precio = e.precio
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
