using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BE
{
    public class CFuncion
    {
        public int id_funcion { get; set; }
        public string NombrePelicula { get; set; }
        public DateTime horario { get; set; }
        public string tipo_funcion { get; set; }
        public int id_tipo_funcion { get; set; }
        public string sala { get; set; }
        public double precio { get; set; }
        public int id_sala { get; set; }
    }
}
