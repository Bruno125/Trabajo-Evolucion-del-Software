using CineEvo.BL.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvoTest
{
    public class BaseTest
    {
        /// <summary>
        /// Este metodo sirve para probar que la conexion a la bd se realice de forma correcta.
        /// Para que este metodo no falle la cadena de conexion y la base de datos deben estar
        /// correctamente configuradas
        /// </summary>
        [Test]
        public void ConnectionTest()
        {
            BaseUtils BaseUtils = new BaseUtils();
            Assert.DoesNotThrow(()=>BaseUtils.GetConnection());
        }

    }
}
