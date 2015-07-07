using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CineEvo.DataModel;
using CineEvo.Util;

namespace CineEvo.BL
{
    public class AsientoBL
    {
        private CineEvoEntities datacontext;

        public AsientoBL()
        {
            datacontext = new CineEvoEntities();
        }
        public List<AsientoPintar> ListarAsiento()
        {
            return datacontext.AsientoPintar.ToList();
        }

        public List<AsientosComprados> ObtenerAsientosComprados(int idSala)
        {
            return (from ap in datacontext.AsientoPintar
                    join a in datacontext.Asiento
                        on ap.codigo equals a.codigo
                       where (a.idSala==idSala && a.estado=="VEN")
                    select new AsientosComprados
                    {
                        AsientoId = a.idAsiento,
                        codigo = a.codigo,
                        X = ap.X,
                        Y = ap.Y,
                       
                    }).ToList();

        }

        public AsientoPintar obtenerAsientoPintar(string codigo)
        {
            return datacontext.AsientoPintar.FirstOrDefault(x => x.codigo.Equals(codigo));
        }



    }
}
