using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineEvo.UI.Controls
{
    public partial class BaseControl : UserControl
    {
        public bool HasOwnNavigationBar
        {
            get
            {
                return true;
            }
            set { }
        }
        protected ControlListener ControlListener;
        public BaseControl()
        {
            InitializeComponent();
        }

        public BaseControl(ControlListener ControlListener)
        {
            InitializeComponent();
            this.ControlListener = ControlListener;
        }

        public void SetTitulo(string titulo)
        {
            LblTitulo.Text = titulo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(ControlListener!=null)
                ControlListener.BackPressed();
        }
    }

    public interface ControlListener{
        void BackPressed();
    }
}
