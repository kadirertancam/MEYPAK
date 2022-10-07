using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
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
        public DbSet<MPSTOKFIYATLISTHAR> MPSTOKFIYATLISTHAR { get; set; }
        public DbSet<MPARACLAR> MPARACLAR { get; set; }
        public DbSet<MPPERSONEL> MPPERSONEL { get; set; }
        public DbSet<MPSTOKSAYIM> MPSTOKSAYIM { get; set; }
        public DbSet<MPSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
        public DbSet<MPOLCUBR> MPOLCUBR { get; set; }
        public DbSet<MPKATEGORI> MPKATEGORI { get; set; }
        public DbSet<MPSIPARIS> MPSIPARIS { get; set; }
        public DbSet<MPSIPARISDETAY> MPSIPARISDETAY { get; set; }
        public DbSet<MPDEPOTRANSFER> MPDEPOTRANSFER { get; set; }
        public DbSet<MPDEPOTRANSFERBILGI> MPDEPOTRANSFERBILGI { get; set; }
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
            modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKOLCUBR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
            modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
            modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
            modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKOLCUBR).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.OLCUBRID);
            modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.BIRIMID);
            modelBuilder.Entity<MPSTOKSAYIM>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPSTOKSAYIM).HasForeignKey(x => x.STOKSAYIMID); 
            modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKFIYATLISTHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);



            modelBuilder.Entity<MPSTOK>()
      .Navigation(b => b.MPSTOKOLCUBR)
      .UsePropertyAccessMode(PropertyAccessMode.Property);
            modelBuilder.Entity<MPSTOK>()
    .Navigation(b => b.MPSTOKHAR)
    .UsePropertyAccessMode(PropertyAccessMode.Property);
            modelBuilder.Entity<MPSTOK>()
    .Navigation(b => b.MPSTOKSAYIMHAR)
    .UsePropertyAccessMode(PropertyAccessMode.Property);
            modelBuilder.Entity<MPSTOKOLCUBR>()
    .Navigation(b => b.MPOLCUBR)
    .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<MPOLCUBR>()
    .Navigation(b => b.MPSTOKSAYIMHAR)
    .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<MPSTOKSAYIM>()
    .Navigation(b => b.MPSTOKSAYIMHAR)
    .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<MPSTOK>()
    .Navigation(b => b.MPSTOKFIYATLISTHAR)
    .UsePropertyAccessMode(PropertyAccessMode.Property);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
