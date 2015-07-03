using CineEvo.BL.Base;
using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL
{
    public class PeliculaBL : BaseBL<Pelicula,int>
    {
         #region Singleton declaration
        private CineEvoEntities DataContext;
        private static PeliculaBL instance = new PeliculaBL();
        private PeliculaBL() { }
        public static PeliculaBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion

        public void Insertar(Pelicula Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(Pelicula Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public Pelicula Obtener(int Id)
        {
            try
            {
                return DataContext.Pelicula.FirstOrDefault(x => x.idPelicula == Id);
            }
            catch (Exception e)
            {
                throw new Exception("PeliculaBL - obtener : " + e.Message, e);
            }
        }

        public List<Pelicula> Listar()
        {
            try
            {
                return DataContext.Pelicula.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("PeliculaBL - listar : " + e.Message, e);
            }
        }
    }
}
