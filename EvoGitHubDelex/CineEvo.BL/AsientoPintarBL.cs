using CineEvo.BE;
using CineEvo.BL.Base;
using CineEvo.DataModel;
using CineEvo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class AsientoPintarBL : BaseBL<CAsientoPintar, string>
    {
        #region Singleton impl
        private CineEvoEntities DataContext;
        private static AsientoPintarBL instance = new AsientoPintarBL();
        private AsientoPintarBL() { }
        public static AsientoPintarBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public void Insertar(CAsientoPintar Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(CAsientoPintar Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(string Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public CAsientoPintar Obtener(string Id)
        {
            AsientoPintar AsientoPintar = null;
            try
            {
                AsientoPintar = DataContext.AsientoPintar.FirstOrDefault(x => x.codigo.Equals(Id));
            }
            catch (Exception e)
            {
                throw new Exception("AsientoPintarBL - obtener : " + e.Message, e);
            }
            return FromEntity(AsientoPintar);
        }

        public List<CAsientoPintar> Listar()
        {
            try
            {
                return DataContext.AsientoPintar.ToList().Select(x => FromEntity(x)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("AsientoPintarBL - listar : " + e.Message, e);
            }
        }

        public CAsientoPintar FromEntity(AsientoPintar Entity)
        {

            CAsientoPintar AsientoPintar = null;
            if (Entity != null)
            {
                AsientoPintar = new CAsientoPintar()
                {
                    codigo = Entity.codigo,
                    X = Entity.X,
                    Y = Entity.Y
                };
            }
            return AsientoPintar;
        }

        public List<AsientosComprados> ListarAsientosComprados(int idSala)
        {
            return (from ap in DataContext.AsientoPintar
                    join a in DataContext.Asiento
                        on ap.codigo equals a.codigo
                    where (a.idSala == idSala && a.estado == "VEN")
                    select new AsientosComprados
                    {
                        AsientoId = a.idAsiento,
                        codigo = a.codigo,
                        X = ap.X,
                        Y = ap.Y,

                    }).ToList();

        }

    }
}
