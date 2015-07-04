using CineEvo.BL;
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

        [Test, TestCaseSource("GetAsientosNullInput")]
        public void AsientoIsNull(AsientoNullTest input)
        {
            Assert.IsNull(AsientoBL.ObtenerInstancia().Obtener(input.id));
        }

        public List<AsientoNullTest> GetAsientosNullInput()
        {
            return CineEvoTestEntities.AsientoNullTest.ToList();
        }

    }
}
