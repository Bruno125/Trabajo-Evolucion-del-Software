using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoGitHubDelex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            //Victor y Mili
            MessageBox.Show("VICTOR Y MILI - EVO 2015-1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
