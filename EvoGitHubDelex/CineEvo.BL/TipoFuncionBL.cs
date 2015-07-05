using CineEvo.BE;
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
        public IList<TipoFuncion> ObtenerTipoFunciones()
        {
            try
            {
                return DataContext.TipoFuncion.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener TipoFunciones : " + e.Message, e);
            }
        }
        public CTipoFuncion ObtenerTipoFuncion(int id)
        {
            return FromEntity(DataContext.TipoFuncion.Single(x => x.idTipoFuncion == id));
        }

        public void Insertar(CTipoFuncion Entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(CTipoFuncion Entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public CTipoFuncion Obtener(int Id)
        {
            CTipoFuncion TipoFuncion;
            try
            {
                return FromEntity(DataContext.TipoFuncion.FirstOrDefault(x => x.idTipoFuncion == Id));
            }
            catch (Exception e)
            {
                throw new Exception("TipoFuncionBL - obtener : " + e.Message, e);
            }
        }

        public List<CTipoFuncion> Listar()
        {
            try
            {
                return (from f in DataContext.TipoFuncion.ToList() select FromEntity(f)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("TipoFuncionBL - listar : " + e.Message, e);
            }
        }

        private CTipoFuncion FromEntity(TipoFuncion f)
        {
            CTipoFuncion TipoFuncion = null;
            if (f != null)
            {
                TipoFuncion = new CTipoFuncion()
                {
                    nombre = f.nombre,
                    precio = f.precio,
                    idTipoFuncion = f.idTipoFuncion
                };
            }
            return TipoFuncion;
        }

    }
}
