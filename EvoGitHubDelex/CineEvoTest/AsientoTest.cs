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
    public class AsientoTest
    {
        private CineEvoTestEntities CineEvoTestEntities = new CineEvoTestEntities();
        AsientoBL AsientoBL = AsientoBL.ObtenerInstancia();

        [Test, TestCaseSource("GetAsientosNullInput")]
        public void AsientoIsNull(AsientoNullTest input)
        {
            Assert.IsNull(AsientoBL.Obtener(input.id));
        }

        public List<AsientoNullTest> GetAsientosNullInput()
        {
            return CineEvoTestEntities.AsientoNullTest.ToList();
        }

        [Test, TestCaseSource("GetAsientosPorSalaInput")]
        public void AsientosPorSala(AsientosPorSalaTest input)
        {
            List<Asiento> asientos = AsientoBL.ListarPorSala(input.idSala);
            foreach (Asiento a in asientos)
            {
                Assert.AreEqual(input.idSala,a.idSala);
            }
        }

        public List<AsientosPorSalaTest> GetAsientosPorSalaInput()
        {
            return CineEvoTestEntities.AsientosPorSalaTest.ToList();
        }

        [Test]
        public void TestValidStates()
        {
            List<Asiento> asientos = AsientoBL.Listar();
            if(asientos.Count>0){
                foreach(Asiento a in asientos){
                    if(!a.estado.Equals(ConstantesModel.ESTADO_ACTIVO) 
                        && !a.estado.Equals(ConstantesModel.ESTADO_INACTIVO))
                        Assert.Fail();
                }
            }
        }

    }
}
