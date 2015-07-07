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
        public class FuncionBL : BaseBL<CFuncion,int>
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

        public void Insertar(CFuncion Entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(CFuncion Entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public CFuncion Obtener(int Id)
        {
            CFuncion funcion;
            try
            {
                return FromEntity(DataContext.Funcion.FirstOrDefault(x => x.idFuncion == Id));
            }
            catch (Exception e)
            {
                throw new Exception("FuncionBL - obtener : " + e.Message, e);
            }
        }

        public List<CFuncion> Listar()
        {
            try
            {
                return (from f in DataContext.Funcion.ToList() select FromEntity(f)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception("FuncionBL - listar : " + e.Message, e);
            }
        }

        public List<CFuncion> ListarFromCine(int idCine)
        {
            List<Funcion> funciones = new List<Funcion>();
            try{
                funciones = (from f in DataContext.Funcion
                                        where f.Sala.idCine == idCine && f.estado.Equals(ConstantesModel.ESTADO_ACTIVO)
                             select f).ToList();
                /*Nota:
                 * Las siguientes lineas sirven para validar correctamente las funciones del dia.
                 * Se puede comentar para simplificar el testeo de la aplicacion. Sin embargo, deben descomentarse
                 * para poder pasar las pruebas unitarias satisfactoriamente.
                */

                //if(funciones!=null)
                //    funciones = funciones.Where(f => (f.fechaFuncion.Date == DateTime.Now &&
                //                              f.fechaFuncion.TimeOfDay < DateTime.Now.TimeOfDay)).ToList();
            }catch(Exception e){
                throw new Exception("FuncionBL - listar from cine: " + e.Message, e);
            }
            return (from f in funciones select FromEntity(f)).ToList();
        }

        private CFuncion FromEntity(Funcion f)
        {
            CFuncion funcion=null;
            if(f!=null){
                funcion = new CFuncion()
                        {
                            NombrePelicula = f.Pelicula.titulo,
                            id_funcion = f.idFuncion,
                            horario = f.fechaFuncion,
                            tipo_funcion = f.TipoFuncion.nombre,
                            id_tipo_funcion = f.TipoFuncion.idTipoFuncion,
                            sala = f.Sala.nombre,
                            id_sala = f.Sala.idSala,
                            precio = f.TipoFuncion.precio,
                            Sala = SalaBL.FromEntity(f.Sala)
                        };
            }
            return funcion;
        }

    }
}
