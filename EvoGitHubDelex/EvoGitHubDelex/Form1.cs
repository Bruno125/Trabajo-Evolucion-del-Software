﻿using System;
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

        List<int> xses;
        List<int> yses;
        List<string> ids;
        int w;
        int defineSeparador;

        public Form1()
        {
            InitializeComponent();

            xses = new List<int>();
            yses = new List<int>();
            ids = new List<string>();
            w = 21;
            defineSeparador = 7;

            generarCoordenadas();

        }

        private void generarCoordenadas()
        {
            //ALGORITMO SALVAJE e.e

            int x = 110, y = 90, separadorX = 0, auxX = 0, auxY = 0, separadorY = 0;
            int numFilas = 10, numCol = 14,contNumeros=1;
            char letra = 'A';
            

            for (int i = 0; i < numFilas; i++)
            {

                for (int j = 0; j < numCol; j++)
                {
                    if (j != 3 && j != 10)
                    {
                       
                        if(contNumeros<10)
                        insertarAListas(x + auxX + separadorX, y + auxY + separadorY,letra+"0"+contNumeros);
                        else
                        insertarAListas(x + auxX + separadorX, y + auxY + separadorY, letra + "" + contNumeros);
                        
                        contNumeros++;
                    }
                    auxX += w;
                    separadorX += defineSeparador;
                }

                contNumeros = 1;
                letra++;
                auxX = 0;
                separadorX = 0;
                separadorY += defineSeparador;
                auxY += w;
            }

        }

        private void insertarAListas(int x,int y,string id)
        {
            xses.Add(x);
            yses.Add(y);
            ids.Add(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dejen sus messagesboxes confirmando que lo probaron en su casa :D
            MessageBox.Show("MUCHACHOS YA LO PROBÉ EN MI CASA - ALEX MATIAS DEL PIRÚ", "DELEX", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("PROBADO - VICTOR CHUQUIHUACCHA", "TIME IS SO UNKIND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("POR FIN ME INSTALÉ VISUAL U_U", "BRUNO AYBAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            int Wreal = (int)gr.VisibleClipBounds.Width-panel1.Width;
            int Hreal = (int)gr.VisibleClipBounds.Height;
            BufferedGraphicsContext espaciobuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = espaciobuffer.Allocate(gr, new Rectangle(0, 0, Wreal, Hreal));
            buffer.Graphics.Clear(this.BackColor);
            //AQUI VA LOS DIBUJOS

           // buffer.Graphics.FillEllipse(new SolidBrush(Color.Blue),30,30,30,30);
            for (int i = 0; i < xses.Count; i++)
            {
                buffer.Graphics.FillRectangle(new SolidBrush(Color.Brown), xses[i], yses[i], w, w);
                buffer.Graphics.DrawString(ids[i], new Font("Arial Black", 6), new SolidBrush(Color.White), xses[i]+w/10, yses[i]+w/4);
            }


                buffer.Render(gr);
        }
    }
}
