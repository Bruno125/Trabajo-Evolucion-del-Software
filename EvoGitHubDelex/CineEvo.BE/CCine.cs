using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineEvo.BL;
using CineEvo.DataModel;
using System.Collections;

using System.Drawing;

namespace CineEvo.BE
{
    public class CCine
    {
        public List<CAsiento> listaAsientos;
        private VentaBL objVentaBL;
        

        public CCine(int idSala)
        {
            listaAsientos = new List<CAsiento>();
            objVentaBL = new VentaBL();

            TraerAsientosDeBaseDeDatos(idSala);
        }

        public void TraerAsientosDeBaseDeDatos(int idSala)
        {
            AsientoBL objAsientoBL = new AsientoBL();
            listaAsientos = new List<CAsiento>();
            List<AsientoPintar> aux = objAsientoBL.ListarAsiento();
            CAsiento objAsientoAux;
            //IEnumerable<Object> lista = objAsientoBL.ObtenerAsientosComprados(idSala);
           // CAsiento nueva = (CAsiento)lista.First();
            
                      


            for(int i=0;i<aux.Count;i++)
            {
                objAsientoAux = new CAsiento();
                objAsientoAux.codigo = aux[i].codigo;
                objAsientoAux.X = aux[i].X.Value;
                objAsientoAux.Y = aux[i].Y.Value;
                objAsientoAux.Ancho = 15;
                objAsientoAux.Largo = 15;
                objAsientoAux.comprado = false;
                objAsientoAux.ClienteComprador = "";

                listaAsientos.Add(objAsientoAux);
            }

        }

        public void DibujarAsientos(Graphics g)
        {
            foreach (CAsiento a in listaAsientos)
                a.Dibujar(g);
        }

        public void DibujarAsientosOcupados(Graphics g, Bitmap bmpUser)
        {
            VentaBL objVentaBL = new VentaBL();
            
                foreach (CAsiento a in listaAsientos)
                {
                    if(a.comprado==true)
                            a.DibujarOcupados(g, bmpUser);                    
                }
        }


        
    }
}
