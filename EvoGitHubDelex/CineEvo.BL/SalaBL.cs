using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class SalaBL
    {
         #region Singleton declaration
        private CineEvoEntities DataContext;
        private static SalaBL instance = new SalaBL();
        private SalaBL() { }
        public static SalaBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public IList<Sala> ObtenerSalas()
        {
            try
            {
                return DataContext.Sala.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener sala : " + e.Message,e);
            }
        }
    }
}
