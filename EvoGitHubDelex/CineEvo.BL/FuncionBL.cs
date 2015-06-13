using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CineEvo.BE;

namespace CineEvo.BL
{
    public class FuncionBL
    {
        #region Singleton declaration
        private CineEvoEntities DataContext;
        private static FuncionBL instance = new FuncionBL();
        private FuncionBL() { }
        public static  FuncionBL ObtenerInstancia()
        {
            instance.DataContext = new CineEvoEntities();
            return instance;
        }
        #endregion
        public IList<Funcion> ObtenerFunciones()
        {
            try
            {
                return DataContext.Funcion.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("BL obtener funciones : " + e.Message,e);
            }
        }
        public Funcion ObtenerFuncion(int id)
        {
            return DataContext.Funcion.FirstOrDefault(x => x.idFuncion == id);
        }
        public IEnumerable<Object> ObtenerFuncionesRenovado(int idCineSeleccionado)
        {
            //FALTA PONER EL DateTime.Compare(now,pf.fechaFuncion)<0 , LO OBVIE PARA VENTAJAS DE TESTING
            return (from f in DataContext.Funcion where f.estado=="ACT" && f.Sala.idCine==idCineSeleccionado
                    select new{
                    NombrePelicula=f.Pelicula.titulo,
                    id_funcion=f.idFuncion,
                    horario=f.fechaFuncion,
                    tipo_funcion=f.TipoFuncion.nombre,
                    id_tipo_funcion=f.TipoFuncion.idTipoFuncion,
                    sala=f.Sala.nombre,
                    id_sala=f.Sala.idSala,
                    precio=f.TipoFuncion.precio
                
            }).ToList();

        }


   
        
                        

    }
}
