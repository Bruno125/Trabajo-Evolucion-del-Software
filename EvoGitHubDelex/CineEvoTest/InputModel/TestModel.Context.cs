﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineEvoTest.InputModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CineEvoTestEntities : DbContext
    {
        public CineEvoTestEntities()
            : base("name=CineEvoTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AsientoNullTest> AsientoNullTest { get; set; }
        public virtual DbSet<AsientosPorSalaTest> AsientosPorSalaTest { get; set; }
        public virtual DbSet<FuncionsPorCineTest> FuncionsPorCineTest { get; set; }
        public virtual DbSet<FuncionNullTest> FuncionNullTest { get; set; }
    }
}
