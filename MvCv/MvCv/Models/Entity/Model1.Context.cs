﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities : DbContext
    {
        public DbCvEntities()
            : base("name=DbCvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Deneyimler> Deneyimler { get; set; }
        public virtual DbSet<Egitimler> Egitimler { get; set; }
        public virtual DbSet<Hakkında> Hakkında { get; set; }
        public virtual DbSet<Hobiler> Hobiler { get; set; }
        public virtual DbSet<İletişim> İletişim { get; set; }
        public virtual DbSet<Sertifikalar> Sertifikalar { get; set; }
        public virtual DbSet<Yetenekler> Yetenekler { get; set; }
        public virtual DbSet<SosyalMedya> SosyalMedya { get; set; }
    }
}
