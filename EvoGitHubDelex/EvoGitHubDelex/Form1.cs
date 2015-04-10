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
            //Dejen sus messagesboxes confirmando que lo probaron en su casa :D
            MessageBox.Show("MUCHACHOS YA LO PROBÉ EN MI CASA - ALEX MATIAS DEL PIRÚ", "DELEX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("PROBADO - VICTOR CHUQUIHUACCHA", "TIME IS SO UNKIND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("POR FIN ME INSTALÉ VISUAL U_U", "BRUNO AYBAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
            
        }
    }
}
