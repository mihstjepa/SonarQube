﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistarAutomobila.Modeli
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<MarkaAutomobila> MarkaAutomobila { get; set; }
        public virtual DbSet<ModelAutomobila> ModelAutomobila { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
    }
}
