using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class PeliculaBL
    {
         #region Singleton declaration
        private CineEvoEntities DataContext;
        private static PeliculaBL instance = new PeliculaBL();
        private PeliculaBL() { }
        public static PeliculaBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public IList<Pelicula> ObtenerPeliculas()
        {
            try
            {
                return DataContext.Pelicula.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener funciones : " + e.Message,e);
            }
        }
    }
}
