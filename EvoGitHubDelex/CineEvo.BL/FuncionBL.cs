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
        public CFuncion ObtenerFuncion(int id)
        {
            return FromEntity(DataContext.Funcion.Single(x => x.idFuncion == id));
        }

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
            try
            {
                return FromEntity(DataContext.Funcion.Where(x => x.idFuncion == Id).Single());
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
            //FALTA PONER EL DateTime.Compare(now,pf.fechaFuncion)<0 , LO OBVIE PARA VENTAJAS DE TESTING
            DateTime now = new DateTime();
            List<Funcion> funciones = new List<Funcion>();
            try{
                funciones = (from f in DataContext.Funcion
                                        where f.Sala.idCine == idCine && f.estado.Equals(ConstantesModel.ESTADO_ACTIVO)
                                        //Z&& DateTime.Compare(now, f.fechaFuncion) < 0 
                                        select f).ToList();
            }catch(Exception e){
                throw new Exception("FuncionBL - listar from cine: " + e.Message, e);
            }
            return (from f in funciones select FromEntity(f)).ToList();
        }

        private CFuncion FromEntity(Funcion f)
        {
            return new CFuncion
                    {
                        NombrePelicula = f.Pelicula.titulo,
                        id_funcion = f.idFuncion,
                        horario = f.fechaFuncion,
                        tipo_funcion = f.TipoFuncion.nombre,
                        id_tipo_funcion = f.TipoFuncion.idTipoFuncion,
                        sala = f.Sala.nombre,
                        id_sala = f.Sala.idSala,
                        precio = f.TipoFuncion.precio,

                    };
        }

    }
}
