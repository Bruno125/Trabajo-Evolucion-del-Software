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
    public class PeliculasTest
    {
        private CineEvoTestEntities CineEvoTestEntities = new CineEvoTestEntities();
        PeliculaBL PeliculaBL = PeliculaBL.ObtenerInstancia();

        [Test]
        public void PeliculaIsNull()
        {
            Assert.IsNull(PeliculaBL.Obtener(-1));
        }

        [Test]
        public void ValidatePeliculasActive()
        {
            List<CPelicula> Peliculas = PeliculaBL.Listar();
            foreach (CPelicula c in Peliculas)
            {
                Assert.IsTrue(c.estado.Equals(ConstantesModel.ESTADO_ACTIVO));
            }
        }

        /// <summary>
        /// Es esta app no deben poder realizarse inserts ni deletes de la Cinees
        /// a la bd de dato, por lo cual estos metodos no deberían tener implementacion
        /// </summary>
        [Test]
        public void PeliculasCrudNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => PeliculaBL.Actualizar(new CPelicula()));
            Assert.Throws<NotImplementedException>(() => PeliculaBL.Insertar(new CPelicula()));
            Assert.Throws<NotImplementedException>(() => PeliculaBL.Eliminar(1));
        }

    }
}
