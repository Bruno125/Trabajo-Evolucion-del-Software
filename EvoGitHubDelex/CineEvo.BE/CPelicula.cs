using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BE
{
    public class CPelicula
    {
        public int idPelicula { get; set; }
        public string actores { get; set; }
        public int idCalificacion { get; set; }
        public int idCategoria { get; set; }
        public string director { get; set; }
        public DateTime fechaEstreno { get; set; }
        public int duracion { get; set; }
        public string titulo { get; set; }
        public string urlTrailer { get; set; }
        public string estado { get; set; }
    }
}
