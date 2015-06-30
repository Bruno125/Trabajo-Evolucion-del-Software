﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace CineEvo.BE
{
    public class CAsiento
    {
        public int AsientoId { get; set; }
        public string codigo { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }              
        public bool comprado { get; set; }
        public string ClienteComprador { get; set; }

        public int margenSup { get; set; }
        public int margenLeft { get; set; }

        public CAsiento()
        {
            margenSup = 35;
            margenLeft = 30;
        }

        public void Dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), X + margenLeft, Y + margenSup, Ancho, Largo);
            g.DrawString(codigo, new Font("Arial", 6), new SolidBrush(Color.White), X + margenLeft, Y + Largo / 10 + margenSup);
        }

        public void DibujarOcupados(Graphics g, Bitmap bmpUser)
        {
            g.FillRectangle(new SolidBrush(Color.Red), X + margenLeft, Y + margenSup, Ancho, Largo);
            g.DrawImage(bmpUser, X + Largo / 10 + 1 + margenLeft, Y + 2 + margenSup, Ancho - 4, Largo - 4);
            //.DrawString(Nombre, new Font("Arial", 6), new SolidBrush(Color.White), X, Y + Largo / 10);
        }

        public bool EstaSeleccionado(int cX, int cY)
        {
            return cX >= X + margenLeft && cX <= X + Ancho + margenLeft && cY >= Y + margenSup && cY <= Y + Largo + margenSup; // SI ESTA DENTRO DEL CUADRAO
        }


    }
}
