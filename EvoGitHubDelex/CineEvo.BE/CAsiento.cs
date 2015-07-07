using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CineEvo.BE
{
    public class CAsiento
    {
        public static readonly string ESTADO_ACTIVO = "ACT";
        public static readonly string ESTADO_INACTIVO = "VEN";

        public int idAsiento { get; set; }
        public string codigo { get; set; }
        public int idSala { get; set; }
        public string estado { get; set; }

       

    }
}
