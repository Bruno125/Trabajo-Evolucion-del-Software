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
    public class PeliculaBL : BaseBL<CPelicula,int>
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

        public void Insertar(CPelicula Entity)
        {
            //No se realizaran operaciones de insercion para esta entidad
            throw new NotImplementedException();
        }

        public void Actualizar(CPelicula Entity)
        {
            //No se realizaran operaciones de actualizacion para esta entidad
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            //No se realizaran operaciones de eliminacion para esta entidad
            throw new NotImplementedException();
        }

        public CPelicula Obtener(int Id)
        {
            try
            {
                return FromEntity(DataContext.Pelicula.FirstOrDefault(x => x.idPelicula == Id));
            }
            catch (Exception e)
            {
                throw new Exception("PeliculaBL - obtener : " + e.Message, e);
            }
        }

        public List<CPelicula> Listar()
        {
            try
            {
                return DataContext.Pelicula.ToList().Select(x=>FromEntity(x)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("PeliculaBL - listar : " + e.Message, e);
            }
        }

        public CPelicula FromEntity(Pelicula Entity)
        {
            CPelicula pelicula = null;
            if (Entity != null)
            {
                pelicula = new CPelicula()
                {
                    actores = Entity.actores,
                    director = Entity.director,
                    duracion = Entity.duracion,
                    estado = Entity.estado,
                    fechaEstreno = Entity.fechaEstreno,
                    idCalificacion = Entity.idCalificacion,
                    idCategoria = Entity.idCategoria,
                    idPelicula = Entity.idPelicula,
                    titulo = Entity.titulo,
                    urlTrailer = Entity.urlTrailer
                };
            }
            return pelicula;
        }

    }
}
