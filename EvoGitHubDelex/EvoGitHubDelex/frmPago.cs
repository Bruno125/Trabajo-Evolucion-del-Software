using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineEvo.UI
{
    public partial class frmPago : Form
    {
        public int TotalPago;
        public string Cine;
        public string Pelicula;
        public DateTime FechaFuncion;
        public string TipoPelicula;
        public string Sala;


        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            LblTotalPago.Text = TotalPago.ToString();
            LblDineroIngresado.Text = "0";
            LblVuelto.Text = "0";

            LblCine.Text = "Cine: " + Cine;
            LblPelicula.Text = "Pelicula: " + Pelicula;
            LblFecha.Text = "Fecha: " + FechaFuncion.ToString().Substring(0, 10);
            LblHorario.Text = "Horario: " + FechaFuncion.ToString().Substring(11);
            LblTipoPelicula.Text = "Tipo de Pelicula: " + TipoPelicula;
            LblSala.Text = "Sala de Prueba: " + Sala;

        }

        private void frmPago_KeyDown(object sender, KeyEventArgs e)
        {
            int aumenta = 0;
            switch (e.KeyCode)
            {
                case Keys.D1:
                    aumenta=1;
                    break;
                case Keys.D2:
                    aumenta=2;
                    break;
                case Keys.D3:
                    aumenta=5;
                    break;
                case Keys.D4:
                    aumenta=10;
                    break;
                case Keys.D5:
                    aumenta=20;
                    break;
                case Keys.D6:
                    aumenta=50;
                    break;
                case Keys.D7:
                    aumenta=50;
                    break;
                default:
                    aumenta=0;
                    break;
            }
            //Cantidad que se acaba de ingresar
            int DineroIngresado = Int32.Parse(LblDineroIngresado.Text.ToString());
            //Actualizo el dinero
            LblDineroIngresado.Text = (DineroIngresado + aumenta).ToString();
            //Re-calculo del dinero actual
            DineroIngresado = Int32.Parse(LblDineroIngresado.Text.ToString());
            
            //Valido que el saldo cubra el Total de Dinero
            if(TotalPago>DineroIngresado)
            {
                LblVuelto.Text = "0";
            }
            else
            {
                //Mostar un mensaje que ya se puede efectuar el pago
                //Bloquear el ingreso de monedas
                LblVuelto.Text = (-1*(TotalPago - DineroIngresado)).ToString();
            }
            


        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            //Re-direccion a la pantalla principal
            //Por el momento solo cerrar esta pantalla
            this.Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            //TODO: frmComprobante victor
            //frmComprobante frm = new frmComprobante();
            ////Diseño de la ventana
            //frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //frm.Text = "Comprobante";
            //frm.StartPosition = FormStartPosition.CenterScreen;
            ////El atributo multiline en el TxtComprobante esta activado
            //frm.Cine = Cine;
            //frm.Pelicula = Pelicula;            

            //frm.Show();
        }
    }
}
