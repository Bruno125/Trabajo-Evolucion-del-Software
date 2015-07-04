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

        //[Test, TestCaseSource("FuncionsPorCineTest")]
        //public void FuncionsPorCineTest(FuncionsPorCineTest input)
        //{
        //    List<CFuncion> Funcions = FuncionBL.ListarFromCine(input.idCine);
        //    foreach (CFuncion a in Funcions)
        //    {
        //        Assert.AreEqual(input.idCine, a.sala);
        //    }
        //}

        [Test, TestCaseSource("FuncionsPorCineTest")]
        public void ValidateFuncionesFromToday(FuncionsPorCineTest input)
        {
            List<CFuncion> Funcions = FuncionBL.ListarFromCine(input.idCine);
        }

        public List<FuncionsPorCineTest> FuncionsPorCineTest()
        {
            return CineEvoTestEntities.FuncionsPorCineTest.ToList();
        }



    }
}
