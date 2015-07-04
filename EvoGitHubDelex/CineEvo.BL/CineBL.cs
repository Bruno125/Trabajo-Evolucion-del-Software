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
    public class CineBL : BaseBL<Cine,int>
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

        public void Insertar(Cine Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(Cine Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public Cine Obtener(int Id)
        {
            try
            {
                return DataContext.Cine.Where(x => x.idCine == Id).Single();
            }
            catch (Exception e)
            {
                throw new Exception("CineBl - obtener : " + e.Message, e);
            }
        }

        public List<Cine> Listar()
        {
            try
            {
                return instance.DataContext.Cine.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("CineBL - listar : " + e.Message, e);
            }
        }

        public static CCine FromEntity(Cine f)
        {
            return new CCine
                    {
                        email = f.direccion,
                        direccion = f.direccion,
                        estado = f.estado,
                        idCine = f.idCine,
                        nombre = f.nombre,
                        telefono = f.telefono
                    };
        }
    }
}
