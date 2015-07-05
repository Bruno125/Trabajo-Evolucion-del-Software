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
    public class TipoEntradasTest
    {
        private CineEvoTestEntities CineEvoTestEntities = new CineEvoTestEntities();
        TipoEntradaBL TipoEntradaBL = TipoEntradaBL.ObtenerInstancia();

        [Test]
        public void TipoEntradaIsNull()
        {
            Assert.IsNull(TipoEntradaBL.Obtener(-1));
        }

        [Test]
        public void ValidateTipoEntradasActive()
        {
            List<CTipoEntrada> TipoEntradas = TipoEntradaBL.Listar();
            foreach (CTipoEntrada c in TipoEntradas)
            {
                //Assert.IsTrue(c..Equals(ConstantesModel.ESTADO_ACTIVO));
            }
        }

        /// <summary>
        /// Es esta app no deben poder realizarse inserts ni deletes de la Cinees
        /// a la bd de dato, por lo cual estos metodos no deberían tener implementacion
        /// </summary>
        [Test]
        public void TipoEntradasCrudNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => TipoEntradaBL.Actualizar(new CTipoEntrada()));
            Assert.Throws<NotImplementedException>(() => TipoEntradaBL.Insertar(new CTipoEntrada()));
            Assert.Throws<NotImplementedException>(() => TipoEntradaBL.Eliminar(1));
        }

    }
}
