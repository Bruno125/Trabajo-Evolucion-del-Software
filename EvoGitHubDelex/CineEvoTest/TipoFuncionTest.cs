using CineEvo.BE;
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
    class TipoFuncionTest
    {
        private CineEvoTestEntities CineEvoTestEntities = new CineEvoTestEntities();
        TipoFuncionBL TipoFuncionBL = TipoFuncionBL.ObtenerInstancia();

        [Test]
        public void TipoFuncionIsNull()
        {
            Assert.IsNull(TipoFuncionBL.Obtener(-1));
        }

        [Test]
        public void ValidateTipoFuncionsActive()
        {
            List<CTipoFuncion> TipoFuncions = TipoFuncionBL.Listar();
            foreach (CTipoFuncion c in TipoFuncions)
            {
                //Assert.IsTrue(c..Equals(ConstantesModel.ESTADO_ACTIVO));
            }
        }

        /// <summary>
        /// Es esta app no deben poder realizarse inserts ni deletes de la Cinees
        /// a la bd de dato, por lo cual estos metodos no deberían tener implementacion
        /// </summary>
        [Test]
        public void TipoFuncionsCrudNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => TipoFuncionBL.Actualizar(new CTipoFuncion()));
            Assert.Throws<NotImplementedException>(() => TipoFuncionBL.Insertar(new CTipoFuncion()));
            Assert.Throws<NotImplementedException>(() => TipoFuncionBL.Eliminar(1));
        }

    }
}
