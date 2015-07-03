using CineEvo.BL.Base;
using CineEvo.DataModel;
using CineEvo.DataModel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class SalaBL : BaseBL<Sala,int>
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

        public void Insertar(Sala Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(Sala Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public Sala Obtener(int Id)
        {
            try
            {
                return DataContext.Sala.FirstOrDefault(x => x.idSala == Id);
            }
            catch (Exception e)
            {
                throw new Exception("SalaBL - obtener : " + e.Message, e);
            }
        }

        public List<Sala> Listar()
        {
            try
            {
                return DataContext.Sala.Where(X=>X.estado.Equals(ConstantesModel.ESTADO_ACTIVO)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("SalaBL - listar: " + e.Message, e);
            }
        }
    }
}
