using CineEvo.BL.Base;
using CineEvo.DataModel;
using CineEvo.DataModel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineEvo.BE;

namespace CineEvo.BL
{
    public class SalaBL : BaseBL<CSala,int>
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

        public void Insertar(CSala Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(CSala Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public CSala Obtener(int Id)
        {
            try
            {
                return SalaBL.FromEntity(DataContext.Sala.FirstOrDefault(x => x.idSala == Id));
            }
            catch (Exception e)
            {
                throw new Exception("SalaBL - obtener : " + e.Message, e);
            }
        }

        public List<CSala> Listar()
        {
            try
            {
                return (from s in DataContext.Sala.Where(X => X.estado.Equals(ConstantesModel.ESTADO_ACTIVO))
                        select SalaBL.FromEntity(s)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("SalaBL - listar: " + e.Message, e);
            }
        }

        public static CSala FromEntity(Sala Entity)
        {
            return new CSala()
            {
                asientosLibres = Entity.asientosLibres,
                capacidad = Entity.capacidad,
                Cine = CineBL.FromEntity(Entity.Cine),
                estado = Entity.estado,
                idCine = Entity.idCine,
                idSala = Entity.idSala,
                nombre = Entity.nombre
            };
        }


    }
}
