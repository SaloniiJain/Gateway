﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBS.DAL.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SBSDbContext : DbContext
    {
        public SBSDbContext()
            : base("name=SBSDbContext")
        {
        }
        public void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppointBooking> AppointBookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dealer> Dealers { get; set; }
        public virtual DbSet<Mechanic> Mechanics { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}