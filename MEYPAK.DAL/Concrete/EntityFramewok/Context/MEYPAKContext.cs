using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using MEYPAK.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Protocols; 

namespace MEYPAK.DAL.Concrete.EntityFramework.Context
{
    public partial class MEYPAKContext : DbContext
    {
        public MEYPAKContext()
        {
        }

         public MEYPAKContext(DbContextOptions<MEYPAKContext> options)
            : base(options)
        {
            
        }
        public DbSet<MPSTOK> MPSTOK { get; set; }
        public DbSet<MPSTOKHAR> MPSTOKHAR { get; set; }
        public DbSet<MPDEPO> MPDEPO { get; set; }
        public DbSet<MPHIZMET> MPHIZMET { get; set; }
        public DbSet<MPMARKA> MPMARKA { get; set; }
        public DbSet<MPSTOKOLCUBR> MPSTOKOLCUBR { get; set; }
        public DbSet<MPSTOKFIYATLIST> MPSTOKFIYATLIST { get; set; }
        public DbSet<MPARACLAR> MPARACLAR { get; set; }
        public DbSet<MPPERSONEL> MPPERSONEL { get; set; }
        public DbSet<MPSTOKSAYIM> MPSTOKSAYIM { get; set; } 
        public DbSet<MPSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
        public DbSet<MPOLCUBR> MPOLCUBR { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseSqlServer("Server=213.238.167.117;Database=MEYPAK;User Id=sa;Password=sapass_1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

            OnModelCreatingPartial(modelBuilder); 
               

        }
         
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
