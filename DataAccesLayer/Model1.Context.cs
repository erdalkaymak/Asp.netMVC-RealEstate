﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccesLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbEmlakEntities1 : DbContext
    {
        public DbEmlakEntities1()
            : base("name=DbEmlakEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Bagımsız_Ozellikler> Bagımsız_Ozellikler { get; set; }
        public virtual DbSet<Cephe> Cephe { get; set; }
        public virtual DbSet<DısOzellikler> DısOzellikler { get; set; }
        public virtual DbSet<Durum> Durum { get; set; }
        public virtual DbSet<IcOzellikler> IcOzellikler { get; set; }
        public virtual DbSet<İl> İl { get; set; }
        public virtual DbSet<İlce> İlce { get; set; }
        public virtual DbSet<Konut> Konut { get; set; }
        public virtual DbSet<Mahalle> Mahalle { get; set; }
        public virtual DbSet<Manzara> Manzara { get; set; }
        public virtual DbSet<Muhit> Muhit { get; set; }
        public virtual DbSet<ResimDetay> ResimDetay { get; set; }
        public virtual DbSet<ResimTablo> ResimTablo { get; set; }
        public virtual DbSet<Ulasim> Ulasim { get; set; }
    }
}
