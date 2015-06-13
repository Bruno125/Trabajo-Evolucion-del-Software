using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CineEvo.DataModel;

namespace CineEvo.BL
{
    public class TipoEntradaBL
    {
        #region Singleton declaration
        private CineEvoEntities DataContext;
        private static TipoEntradaBL instance = new TipoEntradaBL();
        private TipoEntradaBL() { }
        public static TipoEntradaBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion
        public IList<TipoEntrada> ObtenerTiposEntrada()
        {
            try
            {
                return DataContext.TipoEntrada.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener tipos entrada : " + e.Message, e);
            }
        }

        public IEnumerable<Object> ObtenerTiposEntradas(double precioFuncion)
        {
            return (from f in DataContext.TipoEntrada
                    where f.estado == "ACT" 
                    select new
                    {
                        nombre_tipo_entrada=f.nombre,
                        precio=f.precio+precioFuncion,
                        id_tipo_entrada=f.idTipoEntrada
                    }).ToList();
        }

    }
}
