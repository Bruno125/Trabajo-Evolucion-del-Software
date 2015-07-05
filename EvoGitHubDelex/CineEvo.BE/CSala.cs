using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BE
{
    public class CSala
    {
        public int idSala { get; set; }
        public int capacidad { get; set; }
        public string nombre { get; set; }
        public string estado { get; set; }
        public int asientosLibres { get; set; }
        public int idCine { get; set; }

        public List<CAsiento> Asientos { get; set; }
        public CCine Cine { get; set; }
    }
}
