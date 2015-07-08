using CineEvo.BE;
using CineEvo.BL;
using CineEvo.DataModel;
using CineEvo.DataModel.Util;
using CineEvoTest.InputModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvoTest
{
    public class FuncionTest
    {
        private CineEvoTestEntities CineEvoTestEntities = new CineEvoTestEntities();
        FuncionBL FuncionBL = FuncionBL.ObtenerInstancia();

        [Test, TestCaseSource("GetFuncionsNullInput")]
        public void FuncionIsNull(FuncionNullTest input)
        {
            Assert.IsNull(FuncionBL.Obtener(input.idFuncion));
        }

        public List<FuncionNullTest> GetFuncionsNullInput()
        {
            return CineEvoTestEntities.FuncionNullTest.ToList();
        }

        [Test, TestCaseSource("FuncionesPorCineTest")]
        public void FuncionsPorCineTest(FuncionsPorCineTest input)
        {
            List<CFuncion> Funcions = FuncionBL.ListarFromCine(input.idCine);
            foreach (CFuncion a in Funcions)
            {
                Assert.AreEqual(input.idCine, a.Sala.idCine);
            }
        }

        [Test, TestCaseSource("FuncionesPorCineTest")]
        public void ValidateFuncionesFromToday(FuncionsPorCineTest input)
        {
            List<CFuncion> Funciones = FuncionBL.ListarFromCine(input.idCine);
            DateTime Now = DateTime.Now;
            if(Funciones.Count>0)
                foreach (CFuncion a in Funciones)
                {
                    bool isToday = a.horario.Date == Now.Date.Date;
                    bool isBeforeTime = Now.TimeOfDay < a.horario.TimeOfDay;
                    Assert.IsTrue(isToday);
                    Assert.IsTrue(isBeforeTime);
                }
        }

        public List<FuncionsPorCineTest> FuncionesPorCineTest()
        {
            return CineEvoTestEntities.FuncionsPorCineTest.ToList();
        }

        /// <summary>
        /// Es esta app no deben poder realizarse inserts ni deletes de la funciones
        /// a la bd de dato, por lo cual estos metodos no deberían tener implementacion
        /// </summary>
        [Test]
        public void FuncionCrudNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => FuncionBL.Actualizar(new CFuncion()));
            Assert.Throws<NotImplementedException>(() => FuncionBL.Insertar(new CFuncion()));
            Assert.Throws<NotImplementedException>(() => FuncionBL.Eliminar(1));
        }

    }
}
