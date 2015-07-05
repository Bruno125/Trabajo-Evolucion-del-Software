using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CineEvo.BE;
using CineEvo.BL.Base;

using CineEvo.DataModel.Util;

namespace CineEvo.BL
{
    public class TipoEntradaBL : BaseBL<CTipoEntrada, int>
    {
        #region Singleton declaration
        private CineEvoEntities DataContext;
        private static TipoEntradaBL instance = new TipoEntradaBL();
        private TipoEntradaBL() { }
        public static TipoEntradaBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion
        public IList<TipoEntrada> ObtenerTipoEntradaes()
        {
            try
            {
                return DataContext.TipoEntrada.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener TipoEntradaes : " + e.Message, e);
            }
        }
        public CTipoEntrada ObtenerTipoEntrada(int id)
        {
            return FromEntity(DataContext.TipoEntrada.Single(x => x.idTipoEntrada == id));
        }

        public void Insertar(CTipoEntrada Entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(CTipoEntrada Entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public CTipoEntrada Obtener(int Id)
        {
            CTipoEntrada TipoEntrada;
            try
            {
                return FromEntity(DataContext.TipoEntrada.FirstOrDefault(x => x.idTipoEntrada == Id));
            }
            catch (Exception e)
            {
                throw new Exception("TipoEntradaBL - obtener : " + e.Message, e);
            }
        }

        public List<CTipoEntrada> Listar()
        {
            try
            {
                return (from f in DataContext.TipoEntrada.ToList() select FromEntity(f)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("TipoEntradaBL - listar : " + e.Message, e);
            }
        }

        private CTipoEntrada FromEntity(TipoEntrada f)
        {
            CTipoEntrada TipoEntrada = null;
            if (f != null)
            {
                TipoEntrada = new CTipoEntrada()
                {
                    nombre = f.nombre,
                    precio = f.precio,
                    idTipoEntrada = f.idTipoEntrada
                };
            }
            return TipoEntrada;
        }

        public IEnumerable<Object> ObtenerTiposEntradas(double precioFuncion)
        {
            return (from f in DataContext.TipoEntrada
                    where f.estado == "ACT"
                    select new
                    {
                        nombre_tipo_entrada = f.nombre,
                        precio = f.precio + precioFuncion,
                        id_tipo_entrada = f.idTipoEntrada
                    }).ToList();
        }

    }
}
