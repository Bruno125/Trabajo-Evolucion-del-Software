using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CineEvo.BE;
using CineEvo.DataModel;

namespace CineEvo.BL
{
    public class VentaBL
    {
        private  CineEvoEntities datacontext;

        public VentaBL()
        {
            datacontext = new CineEvoEntities();
        }

        public int RegistrarVenta(double montoTotal)
        {
            Venta nuevo = new Venta();
            nuevo.totalPrecio = montoTotal;
            nuevo.fechaVenta = DateTime.Now;
            nuevo.estado = "ACT";

            datacontext.Venta.Add(nuevo);

            datacontext.SaveChanges();

            return nuevo.idVenta;
        }

        public void RegistrarEntrada(int idFuncion,int idAsiento,int idVenta)
        {
            Entrada nuevo = new Entrada();
            nuevo.idAsiento = idAsiento;
            nuevo.idFuncion = idFuncion;
            nuevo.idVenta = idVenta;
            nuevo.idTipoEntrada = 3;
            nuevo.estado = "ACT";

            datacontext.Entrada.Add(nuevo);
            datacontext.SaveChanges();
        }

        /*
        public Venta obtenerVentaExistente(int AsientoId)
        {
            return datacontext.Venta == AsientoId);
        }

       
        public List<Venta> obtenterListaVentas(int EventoId)
        {
            // return datacontext.Venta.ToList();
            return datacontext.Venta.Where(x => x.EventoId == EventoId).ToList();
        }

        public List<Venta> ListarVentaFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            return datacontext.Venta.Where(x => x.Fecha >= fechaInicio && x.Fecha <= fechaFinal).ToList();
        }
        */
    }
}
