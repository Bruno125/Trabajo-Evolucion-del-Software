using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class TipoFuncionBL
    {
         #region Singleton declaration
        private CineEvoEntities DataContext;
        private static TipoFuncionBL instance = new TipoFuncionBL();
        private TipoFuncionBL() { }
        public static TipoFuncionBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public IList<TipoFuncion> ObtenerTiposFuncion()
        {
            try
            {
                return DataContext.TipoFuncion.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener tiposs funcion : " + e.Message,e);
            }
        }
    }
}
