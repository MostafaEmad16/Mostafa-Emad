﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopAssmenit
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sin_upEntities : DbContext
    {
        public Sin_upEntities()
            : base("name=Sin_upEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MMM> MMMs { get; set; }
        public virtual DbSet<sinup> sinups { get; set; }
        public virtual DbSet<User_1> User_1 { get; set; }
    }
}
