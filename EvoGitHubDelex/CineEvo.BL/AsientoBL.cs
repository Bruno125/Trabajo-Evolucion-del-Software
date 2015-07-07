using CineEvo.BE;
using CineEvo.BL.Base;
using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class AsientoBL : BaseBL<CAsiento, int>
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

        public void Insertar(CAsiento Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(CAsiento Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public CAsiento Obtener(int Id)
        {
            Asiento asiento = null;
            try
            {
                asiento = DataContext.Asiento.Where(x => x.idAsiento == Id).Single();
            }
            catch (Exception e)
            {
                throw new Exception("AsientoBL - obtener : " + e.Message, e);
            }
            return FromEntity(asiento);
        }

        public List<CAsiento> Listar()
        {
            try
            {
                return DataContext.Asiento.ToList().Select(x => FromEntity(x)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("AsientoBL - listar : " + e.Message, e);
            }
        }

        public List<CAsiento> ListarPorSala(int idSala)
        {
            try
            {
                return DataContext.Asiento.Where(x => x.idSala == idSala).Select(x => FromEntity(x)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("AsientoBL - listar por sala : " + e.Message, e);
            }
        }

        public CAsiento FromEntity(Asiento Entity)
        {
            CAsiento asiento = null;
            if (Entity != null)
            {
                asiento = new CAsiento()
                {
                    codigo = Entity.codigo,
                    estado = Entity.estado,
                    idAsiento = Entity.idAsiento,
                    idSala = Entity.idSala
                };
            }
            return asiento;
        }

    }
}
