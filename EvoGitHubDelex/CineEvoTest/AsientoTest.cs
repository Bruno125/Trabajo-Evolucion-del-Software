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
            List<CAsiento> asientos = AsientoBL.ListarPorSala(input.idSala);
            if(asientos!=null && asientos.Count>0)
                foreach (CAsiento a in asientos)
                {
                    Assert.AreEqual(input.idSala,a.idSala);
                }
            Assert.Pass();
        }

        public List<AsientosPorSalaTest> GetAsientosPorSalaInput()
        {
            return CineEvoTestEntities.AsientosPorSalaTest.ToList();
        }

        [Test]
        public void TestValidStates()
        {
            List<CAsiento> asientos = AsientoBL.Listar();
            if(asientos.Count>0){
                foreach(CAsiento a in asientos){
                    if (!a.estado.Equals(CAsiento.ESTADO_ACTIVO) 
                        && !a.estado.Equals(CAsiento.ESTADO_INACTIVO))
                        Assert.Fail();
                }
            }
        }

        /// <summary>
        /// Es esta app no deben poder realizarse inserts ni deletes de la funciones
        /// a la bd de dato, por lo cual estos metodos no deberían tener implementacion
        /// </summary>
        [Test]
        public void AsientoCrudNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => AsientoBL.Insertar(new CAsiento()));
            Assert.Throws<NotImplementedException>(() => AsientoBL.Eliminar(1));
        }

    }
}
