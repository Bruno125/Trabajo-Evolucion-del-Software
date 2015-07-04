using CineEvo.BL.Base;
using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class AsientoBL : BaseBL<Asiento,int>
    {
        #region Singleton impl
        private CineEvoEntities DataContext;
        private static AsientoBL instance = new AsientoBL();
        private AsientoBL() { }
        public static AsientoBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public void Insertar(Asiento Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(Asiento Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public Asiento Obtener(int Id)
        {
            Asiento asiento = null;
            try
            {
                asiento =  DataContext.Asiento.Where(x => x.idAsiento == Id).Single();
            }
            catch (Exception e)
            {
                throw new Exception("CineBl - obtener : " + e.Message, e);
            }
            return asiento;
        }

        public List<Asiento> Listar()
        {
            try
            {
                return DataContext.Asiento.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("CineBL - listar : " + e.Message, e);
            }
        }

        public List<Asiento> ListarPorSala(int idSala)
        {
            try
            {
                return DataContext.Asiento.Where(x=>x.idSala==idSala).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("CineBL - listar por sala : " + e.Message, e);
            }
        }
    }
}
