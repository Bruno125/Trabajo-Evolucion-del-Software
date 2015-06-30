using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineEvo.BE;
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
