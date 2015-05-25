//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineEvo.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pelicula
    {
        public Pelicula()
        {
            this.Funcion = new HashSet<Funcion>();
        }
    
        public int idPelicula { get; set; }
        public string actores { get; set; }
        public int idCalificacion { get; set; }
        public int idCategoria { get; set; }
        public string director { get; set; }
        public System.DateTime fechaEstreno { get; set; }
        public int duracion { get; set; }
        public string titulo { get; set; }
        public string urlTrailer { get; set; }
        public string estado { get; set; }
    
        public virtual Calificacion Calificacion { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Funcion> Funcion { get; set; }
    }
}