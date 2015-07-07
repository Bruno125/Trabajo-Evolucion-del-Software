using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineEvo.BL;
using CineEvo.DataModel;
using System.Collections;

using System.Drawing;
using CineEvo.Util;

namespace CineEvo.BE
{
     public class CCine
    {
        public List<CAsiento> listaAsientos;
        public List<CAsiento> listaAsientosVendidos;
        private VentaBL objVentaBL;
        

        public CCine(int idSala)
        {
            listaAsientos = new List<CAsiento>();
            listaAsientosVendidos = new List<CAsiento>();
            objVentaBL = new VentaBL();

            TraerAsientosDeBaseDeDatos(idSala);
        }

        public void TraerAsientosDeBaseDeDatos(int idSala)
        {
            AsientoBL objAsientoBL = new AsientoBL();
            listaAsientos = new List<CAsiento>();
            listaAsientosVendidos = new List<CAsiento>();
            List<AsientoPintar> aux = objAsientoBL.ListarAsiento();
            CAsiento objAsientoAux;
            List<AsientosComprados> listaVendidos = objAsientoBL.ObtenerAsientosComprados(idSala);
           
             //Para la lista de asientos general
            for(int i=0;i<aux.Count;i++)
            {
                objAsientoAux = new CAsiento();
                objAsientoAux.codigo = aux[i].codigo;
                objAsientoAux.X = aux[i].X;
                objAsientoAux.Y = aux[i].Y;
                objAsientoAux.Ancho = 20;
                objAsientoAux.Largo = 20;
                objAsientoAux.comprado = false;
                objAsientoAux.seleccionado = false;
                objAsientoAux.ClienteComprador = "";

                listaAsientos.Add(objAsientoAux);
            }
            //Para la lista de asientos comprados
            for (int i = 0; i < listaVendidos.Count; i++)
            {
                
                objAsientoAux = new CAsiento();
                objAsientoAux.codigo = listaVendidos[i].codigo;
                objAsientoAux.X = listaVendidos[i].X;
                objAsientoAux.Y = listaVendidos[i].Y;
                objAsientoAux.Ancho = 20;
                objAsientoAux.Largo = 20;
                objAsientoAux.comprado = true;
                objAsientoAux.seleccionado = false;
                objAsientoAux.ClienteComprador = "";

                listaAsientosVendidos.Add(objAsientoAux); 
            }
            //actualizar los comprads
            for(int i=0;i<listaAsientos.Count;i++)
            {
                for(int j=0;j<listaAsientosVendidos.Count;j++)
                {
                    if (listaAsientos[i].codigo.Equals(listaAsientosVendidos[j].codigo))
                        listaAsientos[i].comprado = true;
                }
            }

            int x = 0;

        }

        public void DibujarAsientos(Graphics g,Bitmap bmpUser)
        {
            foreach (CAsiento a in listaAsientos)
                a.Dibujar(g,bmpUser);
        }

        public void DibujarAsientosOcupados(Graphics g, Bitmap bmpUser)
        {
                        
                foreach (CAsiento a in listaAsientosVendidos)
                {
                    if(a.comprado==true)
                            a.DibujarOcupados(g, bmpUser);                    
                }
        }

         public int cantAsientosSeleccionados()
        {
            int cont = 0;
            foreach (CAsiento a in listaAsientos)
                if (a.seleccionado)
                    cont++;
            return cont;
        }

         public CAsiento traerAsientoClickeado(int cX,int cY,int cantAsientosEscogidos)
        {
            int cantAsientosSelec = cantAsientosSeleccionados();

            if (cantAsientosSelec < cantAsientosEscogidos)
            {
                foreach (CAsiento a in listaAsientos)
                {
                    if (a.comprado != true) //si es que no estan comprados :D (por si existe algun vendido en la lista de Asientos (NODEBERIA HABER))
                        if (a.EstaSeleccionado(cX, cY))
                            return a;
                }              
            }
            else
            {
                foreach (CAsiento a in listaAsientos)
                {
                    if (a.comprado != true && a.seleccionado==true) //si es que no estan comprados :D (por si existe algun vendido en la lista de Asientos (NODEBERIA HABER))
                        if (a.EstaSeleccionado(cX, cY))
                            return a;
                }  
            }

            return null;
        }

        public bool manitoEnCasilla(int cX, int cY, int cantEntradasEscogidas)
        {
                //Primero verifico los vendidos
                foreach (CAsiento a in listaAsientosVendidos)
                {
                    if (a.comprado == true) //si es que no estan comprados :D (TODOS LOS DE ESA LISTA DEBERIAN FIGURAR COMO COMPRADOS)
                        if (a.EstaSeleccionado(cX, cY))
                            return false;
                }
                int cantAsientosSelec = cantAsientosSeleccionados();
            //si es que nos es ninguno de los vendidos 
                if (cantAsientosSelec < cantEntradasEscogidas)
                {
                    foreach (CAsiento a in listaAsientos)
                    {
                        if (a.comprado != true) //si es que no estan comprados :D (por si existe algun vendido en la lista de Asientos (NODEBERIA HABER))
                            if (a.EstaSeleccionado(cX, cY))
                                return true;
                    }
                }
                else
                {
                    foreach (CAsiento a in listaAsientos)
                    {
                        if (a.seleccionado == true) //si es que no estan comprados :D (por si existe algun vendido en la lista de Asientos (NODEBERIA HABER))
                            if (a.EstaSeleccionado(cX, cY))
                                return true;
                    }
                }

                return false;
               
        }


        
    }
}
