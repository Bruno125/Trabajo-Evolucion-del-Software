using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class FuncionBL
    {
        #region Singleton declaration
        private CineEvoEntities DataContext;
        private static FuncionBL instance = new FuncionBL();
        private FuncionBL() { }
        public static FuncionBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public IList<Funcion> ObtenerFunciones()
        {
            try
            {
                return DataContext.Funcion.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener funciones : " + e.Message,e);
            }
        }
    }
}
