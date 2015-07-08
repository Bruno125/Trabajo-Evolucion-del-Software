using CineEvo.BE;
using CineEvo.BL;
using CineEvo.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.UI.ViewModel
{
    public class SalaModel
    {
        public List<AsientoViewModel> listaAsientos;
        public List<AsientoViewModel> listaAsientosVendidos;
        public SalaModel(int idSala)
        {
            listaAsientos = new List<AsientoViewModel>();
            listaAsientosVendidos = new List<AsientoViewModel>();

            TraerAsientosDeBaseDeDatos(idSala);
        }

        public void TraerAsientosDeBaseDeDatos(int idSala)
        {
            AsientoPintarBL objAsientoBL = AsientoPintarBL.ObtenerInstancia();
            objAsientoBL = AsientoPintarBL.ObtenerInstancia();
            listaAsientos = new List<AsientoViewModel>();
            listaAsientosVendidos = new List<AsientoViewModel>();
            List<CAsientoPintar> aux = objAsientoBL.Listar();
            AsientoViewModel objAsientoAux;
            List<AsientosComprados> listaVendidos = objAsientoBL.ListarAsientosComprados(idSala);
           
             //Para la lista de asientos general
            for(int i=0;i<aux.Count;i++)
            {
                objAsientoAux = new AsientoViewModel();
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

                objAsientoAux = new AsientoViewModel();
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
        }

        public void DibujarAsientos(Graphics g,Bitmap bmpUser)
        {
            foreach (AsientoViewModel a in listaAsientos)
                a.Dibujar(g,bmpUser);
        }

        public void DibujarAsientosOcupados(Graphics g, Bitmap bmpUser)
        {

            foreach (AsientoViewModel a in listaAsientosVendidos)
                {
                    if(a.comprado==true)
                            a.DibujarOcupados(g, bmpUser);                    
                }
        }

         public int cantAsientosSeleccionados()
        {
            int cont = 0;
            foreach (AsientoViewModel a in listaAsientos)
                if (a.seleccionado)
                    cont++;
            return cont;
        }

         public AsientoViewModel traerAsientoClickeado(int cX, int cY, int cantAsientosEscogidos)
        {
            int cantAsientosSelec = cantAsientosSeleccionados();

            if (cantAsientosSelec < cantAsientosEscogidos)
            {
                foreach (AsientoViewModel a in listaAsientos)
                {
                    if (a.comprado != true) //si es que no estan comprados :D (por si existe algun vendido en la lista de Asientos (NODEBERIA HABER))
                        if (a.EstaSeleccionado(cX, cY))
                            return a;
                }              
            }
            else
            {
                foreach (AsientoViewModel a in listaAsientos)
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
            foreach (AsientoViewModel a in listaAsientosVendidos)
            {
                if (a.comprado == true) //si es que no estan comprados :D (TODOS LOS DE ESA LISTA DEBERIAN FIGURAR COMO COMPRADOS)
                    if (a.EstaSeleccionado(cX, cY))
                        return false;
            }
            int cantAsientosSelec = cantAsientosSeleccionados();
            //si es que nos es ninguno de los vendidos 
            if (cantAsientosSelec < cantEntradasEscogidas)
            {
                foreach (AsientoViewModel a in listaAsientos)
                {
                    if (a.comprado != true) //si es que no estan comprados :D (por si existe algun vendido en la lista de Asientos (NODEBERIA HABER))
                        if (a.EstaSeleccionado(cX, cY))
                            return true;
                }
            }
            else
            {
                foreach (AsientoViewModel a in listaAsientos)
                {
                    if (a.seleccionado == true) //si es que no estan comprados :D (por si existe algun vendido en la lista de Asientos (NODEBERIA HABER))
                        if (a.EstaSeleccionado(cX, cY))
                            return true;
                }
            }

                return false;
               
        }
    
        public List<Tuple<int,string>> listaDeCodigosSeleccionados(int idSala)
        {
            AsientoPintarBL objAsientoPintarBL=AsientoPintarBL.ObtenerInstancia();
            List<Tuple<int, string>> listaRes = new List<Tuple<int, string>>();
            Tuple<int, string> par;
            foreach (AsientoViewModel a in listaAsientos)
            {
                if (a.seleccionado == true)
                {
                    a.AsientoId = objAsientoPintarBL.obtenerAsiento(idSala, a.codigo);

                    par = new Tuple<int, string>(a.AsientoId, a.codigo);
                    listaRes.Add(par);
                }
            }           

            return listaRes;
        }
    
    }
}
