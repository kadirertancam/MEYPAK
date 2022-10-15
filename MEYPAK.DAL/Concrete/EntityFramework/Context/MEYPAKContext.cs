using MEYPAK.Entity.Models;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using Microsoft.EntityFrameworkCore;


namespace MEYPAK.DAL.Concrete.EntityFramework.Context
{
    public partial class MEYPAKContext : DbContext
    {
        public MEYPAKContext()
        {
            this.ChangeTracker.LazyLoadingEnabled = true;
        }
         
        public MEYPAKContext(DbContextOptions<MEYPAKContext> options)
           : base(options)
        {
            

        }

        public DbSet<MPSTOKSEVKİYATLİST> MPSTOKSEVKİYATLİST { get; set; }
        public DbSet<MPSIPARISSEVKEMRIHAR> MPSIPARISSEVKEMRIHAR { get; set; }
        public DbSet<MPDEPOEMIR> MPDEPOEMIR { get; set; }
        public DbSet<MPSTOK> MPSTOK { get; set; }
        public DbSet<MPSTOKHAR> MPSTOKHAR { get; set; }
        public DbSet<MPDEPO> MPDEPO { get; set; }
        public DbSet<MPHIZMET> MPHIZMET { get; set; }
        public DbSet<MPSTOKMARKA> MPMARKA { get; set; }
        public DbSet<MPSTOKOLCUBR> MPSTOKOLCUBR { get; set; }
        public DbSet<MPSTOKFIYATLIST> MPSTOKFIYATLIST { get; set; }
        public DbSet<MPSTOKFIYATLISTHAR> MPSTOKFIYATLISTHAR { get; set; }
        public DbSet<MPARACLAR> MPARACLAR { get; set; }
        public DbSet<MPPERSONEL> MPPERSONEL { get; set; }
        public DbSet<MPSTOKSAYIM> MPSTOKSAYIM { get; set; }
        public DbSet<MPSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
        public DbSet<MPOLCUBR> MPOLCUBR { get; set; }
        public DbSet<MPSTOKKATEGORI> MPKATEGORI { get; set; }
        public DbSet<MPSIPARIS> MPSIPARIS { get; set; }
        public DbSet<MPSIPARISDETAY> MPSIPARISDETAY { get; set; }
        public DbSet<MPDEPOTRANSFER> MPDEPOTRANSFER { get; set; }
        public DbSet<MPDEPOTRANSFERHAR> MPDEPOTRANSFERHAR { get; set; } 
        public DbSet<MPSTOKMALKABULLIST> MPSTOKMALKABULLIST { get; set; }
        public DbSet<MPSTOKKASA> MPSTOKKASA { get; set; }
        public DbSet<MPIRSALIYE> MPIRSALIYE { get; set; } 
        public DbSet<MPIRSALIYESIPARISDETAYILISKI> MPIRSALIYESIPARISDETAYILISKI { get; set; }
        public DbSet<MPIRSALIYEDETAY> MPIRSALIYEDETAY { get; set; }

        //       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //       {
        //           if (!optionsBuilder.IsConfigured)
        //           {
        //               optionsBuilder.UseSqlServer("Server=213.238.167.117;Database=MEYPAK;User Id=sa;Password=sapass_1;");
        //           } 

        //       }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Stok_Navigation_AutoInclude



            modelBuilder.Entity<MPSTOK>()
   .Navigation(b => b.MPSIPARISDETAY)
   .UsePropertyAccessMode(PropertyAccessMode.Property);

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
            modelBuilder.Entity<MPSIPARIS>()
    .Navigation(b => b.MPSIPARISDETAY)
    .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<MPOLCUBR>()
    .Navigation(b => b.MPSTOKSEVKİYATLİST)
    .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<MPSTOK>()
    .Navigation(b => b.MPSTOKSEVKİYATLİST)
    .UsePropertyAccessMode(PropertyAccessMode.Property);
            modelBuilder.Entity<MPSIPARISDETAY>()
 .Navigation(b => b.MPSTOKSEVKİYATLİST)
 .UsePropertyAccessMode(PropertyAccessMode.Property);







            //modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKOLCUBR).();
            //modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKMALKABULLIST).AutoInclude();
            //modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKSAYIMHAR).AutoInclude();
            //modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKSEVKİYATLİST).AutoInclude();

            //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSIPARISDETAY).AutoInclude();
            //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKFIYATLISTHAR).AutoInclude();
            //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKHAR).AutoInclude();
            //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKMALKABULLIST).AutoInclude();
            //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKOLCUBR).AutoInclude();
            //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKSAYIMHAR).AutoInclude();
            //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKSEVKİYATLİST).AutoInclude();

            //modelBuilder.Entity<MPSTOKFIYATLIST>().Navigation(x => x.MPSTOKFIYATLISTHAR).AutoInclude();

            //modelBuilder.Entity<MPSTOKFIYATLISTHAR>().Navigation(x => x.MPSTOK).AutoInclude();
            //modelBuilder.Entity<MPSTOKFIYATLISTHAR>().Navigation(x => x.MPSTOKFIYATLIST).AutoInclude();

            //modelBuilder.Entity<MPSTOKHAR>().Navigation(x => x.MPSTOK).AutoInclude();

            //modelBuilder.Entity<MPSTOKSAYIM>().Navigation(x => x.MPSTOKSAYIMHAR).AutoInclude();

            //modelBuilder.Entity<MPSTOKSAYIMHAR>().Navigation(x => x.MPSTOK).AutoInclude();
            ////modelBuilder.Entity<MPSTOKSAYIMHAR>().Navigation(x => x.MPOLCUBR).AutoInclude();
            //modelBuilder.Entity<MPSTOKSAYIMHAR>().Navigation(x => x.MPSTOKSAYIM).AutoInclude();

            #endregion

        }
        //           OnModelCreatingPartial(modelBuilder);
        //           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKOLCUBR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        //           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        //           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        //           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKOLCUBR).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.OLCUBRID);
        //           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.BIRIMID);
        //           modelBuilder.Entity<MPSTOKSAYIM>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPSTOKSAYIM).HasForeignKey(x => x.STOKSAYIMID);
        //           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKFIYATLISTHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        //           modelBuilder.Entity<MPSIPARIS>().HasMany(x => x.MPSIPARISDETAY).WithOne(x => x.MPSIPARIS).HasForeignKey(x => x.SIPARISID);
        //           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKSEVKİYATLİST).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.BIRIMID);
        //           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKSEVKİYATLİST).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        //           modelBuilder.Entity<MPSIPARIS>().HasMany(x => x.MPIRSALIYE).WithOne(x => x.MPSIPARIS).HasForeignKey(x => x.SIPARISID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPSIPARISDETAY>().HasMany(x => x.MPSTOKSEVKİYATLİST).WithOne(x => x.MPSIPARISDETAY).HasForeignKey(x => x.SIPARISDETAYID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPSIPARIS>().HasMany(x => x.MPDEPOEMIR).WithOne(x => x.MPSIPARIS).HasForeignKey(x => x.SIPARISID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.BIRIMID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPDEPOEMIR>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPDEPOEMIR).HasForeignKey(x => x.EMIRID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPSIPARISDETAY>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPSIPARISDETAY).HasForeignKey(x => x.SIPARISDETAYID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSIPARISDETAY).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID).OnDelete(DeleteBehavior.Restrict);

        //           modelBuilder.Entity<MPIRSALIYESIPARISDETAYILISKI>().HasKey(sc => new { sc.IRSALIYEDETAYID, sc.SIPARISDETAYID });

        //           modelBuilder.Entity<MPIRSALIYESIPARISDETAYILISKI>()
        //               .HasOne<MPIRSALIYEDETAY>(sc => sc.MPIRSALIYEDETAY)
        //               .WithMany(s => s.MPIRSALIYESIPARISDETAYILISKI)
        //               .HasForeignKey(sc => sc.IRSALIYEDETAYID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPIRSALIYESIPARISDETAYILISKI>()
        //               .HasOne<MPSIPARISDETAY>(sc => sc.MPSIPARISDETAY)
        //               .WithMany(s => s.MPIRSALIYESIPARISDETAYILISKI)
        //               .HasForeignKey(sc => sc.SIPARISDETAYID).OnDelete(DeleteBehavior.Restrict);

        //           modelBuilder.Entity<MPDEPOEMIRSIPARISKALEMILISKI>().HasKey(sc => new { sc.DEPOEMIRID, sc.SIPARISDETAYID });

        //           modelBuilder.Entity<MPDEPOEMIRSIPARISKALEMILISKI>()
        //               .HasOne<MPSIPARISDETAY>(sc => sc.MPSIPARISDETAY)
        //               .WithMany(s => s.MPDEPOEMIRSIPARISKALEMILISKI)
        //               .HasForeignKey(sc => sc.SIPARISDETAYID).OnDelete(DeleteBehavior.Restrict);
        //           modelBuilder.Entity<MPDEPOEMIRSIPARISKALEMILISKI>()
        //               .HasOne<MPDEPOEMIR>(sc => sc.MPDEPOEMIR)
        //               .WithMany(s => s.MPDEPOEMIRSIPARISKALEMILISKI)
        //               .HasForeignKey(sc => sc.DEPOEMIRID).OnDelete(DeleteBehavior.Restrict);


        //           modelBuilder.Entity<MPSTOK>()
        //  .Navigation(b => b.MPSIPARISDETAY)
        //  .UsePropertyAccessMode(PropertyAccessMode.Property);

        //           modelBuilder.Entity<MPSTOK>()
        //     .Navigation(b => b.MPSTOKOLCUBR)
        //     .UsePropertyAccessMode(PropertyAccessMode.Property);
        //           modelBuilder.Entity<MPSTOK>()
        //   .Navigation(b => b.MPSTOKHAR)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);
        //           modelBuilder.Entity<MPSTOK>()
        //   .Navigation(b => b.MPSTOKSAYIMHAR)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);
        //           modelBuilder.Entity<MPSTOKOLCUBR>()
        //   .Navigation(b => b.MPOLCUBR)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);

        //           modelBuilder.Entity<MPOLCUBR>()
        //   .Navigation(b => b.MPSTOKSAYIMHAR)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);

        //           modelBuilder.Entity<MPSTOKSAYIM>()
        //   .Navigation(b => b.MPSTOKSAYIMHAR)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);

        //           modelBuilder.Entity<MPSTOK>()
        //   .Navigation(b => b.MPSTOKFIYATLISTHAR)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);
        //           modelBuilder.Entity<MPSIPARIS>()
        //   .Navigation(b => b.MPSIPARISDETAY)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);

        //           modelBuilder.Entity<MPOLCUBR>()
        //   .Navigation(b => b.MPSTOKSEVKİYATLİST)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);

        //           modelBuilder.Entity<MPSTOK>()
        //   .Navigation(b => b.MPSTOKSEVKİYATLİST)
        //   .UsePropertyAccessMode(PropertyAccessMode.Property);
        //           modelBuilder.Entity<MPSIPARISDETAY>()
        //.Navigation(b => b.MPSTOKSEVKİYATLİST)
        //.UsePropertyAccessMode(PropertyAccessMode.Property);
        //       }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
