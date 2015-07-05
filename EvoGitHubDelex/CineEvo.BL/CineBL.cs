using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using CineEvo.DataModel;
using  CineEvo.BL.Base;
using CineEvo.BE;

namespace CineEvo.BL
{
    public class CineBL : BaseBL<CCine,int>
    {
        
         #region Singleton declaration
        private CineEvoEntities DataContext;
        private static CineBL instance = new CineBL();
        private CineBL() { }
        public static CineBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public void Insertar(CCine Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(CCine Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public CCine Obtener(int Id)
        {
            CCine cine = null;
            try
            {
                cine = CineBL.FromEntity(DataContext.Cine.FirstOrDefault(x => x.idCine == Id));
            }
            catch (Exception e)
            {
                throw new Exception("CineBL - obtener : " + e.Message, e);
            }
            return cine;
        }

        public List<CCine> Listar()
        {
            try
            {
                return DataContext.Cine.ToList().Select(x=> FromEntity(x)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("CineBL - listar : " + e.Message, e);
            }
        }

        public static CCine FromEntity(Cine Entity)
        {
            if (Entity != null)
                return new CCine()
                {
                    direccion = Entity.direccion,
                    email = Entity.email,
                    estado = Entity.estado,
                    idCine = Entity.idCine,
                    nombre = Entity.nombre,
                    telefono = Entity.telefono
                };
            else
                return null;
        } 
    }
}
