using CineEvo.BE;
using CineEvo.BL;
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
    public class CineTest
    {
        private CineEvoTestEntities CineEvoTestEntities = new CineEvoTestEntities();
        CineBL CineBL = CineBL.ObtenerInstancia();

        [Test]
        public void CineIsNull()
        {
            Assert.IsNull(CineBL.Obtener(-1));
        }

        [Test]
        public void ValidateCinesActive()
        {
            List<CCine> Cinees = CineBL.Listar();
            foreach (CCine c in Cinees)
            {
                Assert.IsTrue(c.estado.Equals(ConstantesModel.ESTADO_ACTIVO));
            }
        }

        /// <summary>
        /// Es esta app no deben poder realizarse inserts ni deletes de la Cinees
        /// a la bd de dato, por lo cual estos metodos no deberían tener implementacion
        /// </summary>
        [Test]
        public void CineCrudNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => CineBL.Actualizar(new CCine()));
            Assert.Throws<NotImplementedException>(() => CineBL.Insertar(new CCine()));
            Assert.Throws<NotImplementedException>(() => CineBL.Eliminar(1));
        }

    }
}
