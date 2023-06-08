using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.CEKSENET;
using MEYPAK.Entity.Models.DEKONT;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.DESTEKSERVİS;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.Models.MUSTAHSIL;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace MEYPAK.DAL.Concrete.EntityFramework.Context
{
    public class MEYPAKContext :IdentityDbContext<MPUSER,MPROLE,string>
    {
       
         
        public MEYPAKContext(DbContextOptions<MEYPAKContext> options)
           : base(options)
        {
           

        }

        public DbSet<MPSERIYETKI> MPSERIYETKI { get; set; }
        public DbSet<MPHKSBELDELER> MPHKSBELDELER { get; set; }
        public DbSet<MPHKSILCELER> MPHKSILCELER { get; set; }
        public DbSet<MPHKSILLER> MPHKSILLER { get; set; }
        public DbSet<MPFATURATASLAK> MPFATURATASLAKACBELGE { get; set; }
        public DbSet<MPFATURADETAYTASLAK> MPFATURADETAYTASLAK { get; set; }
        public DbSet<MPIRSALIYETASLAK> MPIRSALIYETASLAK { get; set; }
        public DbSet<MPIRSALIYEDETAYTASLAK> MPIRSALIYEDETAYTASLAK { get; set; }
        public DbSet<MPARACBELGE> MPARACBELGE { get; set; }
        public DbSet<MPARACZIMMET> MPARACZIMMET { get; set; }
        public DbSet<MPARACMUAYENERESIM> MPARACMUAYENERESIM { get; set; }
        public DbSet<MPFATURASTOKESLE> MPFATURASTOKESLE { get; set; }
        public DbSet<MPVERSION> MPVERSION { get; set; }
        public DbSet<MPMUSTAHSIL> MPMUSTAHSIL { get; set; }
        public DbSet<MPGIDENMUSTAHSILMAKBUZLARI> MPGIDENMUSTAHSILMAKBUZLARI { get; set; }
        public DbSet<MPMUSTAHSILDETAY> MPMUSTAHSILDETAY { get; set; }
        public DbSet<MPMUSTAHSILCARI> MPMUSTAHSILCARI { get; set; }
        public DbSet<MPMUSTAHSILCARIHAR> MPMUSTAHSILCARIHAR { get; set; }
        public DbSet<MPFATURASTOKOLCUBR> MPFATURASTOKOLCUBR { get; set; }
        public DbSet<MPGIDENIRSALIYELER> MPGIDENIRSALIYELER { get; set; }
        public DbSet<MPGIDENFATURALAR> MPGIDENFATURALAR { get; set; }
        public DbSet<MPDEKONT> MPDEKONT { get; set; }
        public DbSet<MPEFATURAPARAMS> MPEFATURAPARAM { get; set; }
        public DbSet<MPFORM> MPFORM { get; set; }
        public DbSet<MPFORMYETKI> MPFORMYETKI { get; set; }
        public DbSet<MPSTOKSARF> MPSTOKSARF { get; set; }
        public DbSet<MPPERSONELPARAMETRE> MPPERSONELPARAMETRE { get; set; }
        public DbSet<MPSTOKSARFDETAY> MPSTOKSARFDETAY { get; set; }
        public DbSet<MPMUSTERICEKSENET> MPMUSTERICEKSENET { get; set; }
        public DbSet<MPCEKSENETUSTSB> MPCEKSENETUSTSB { get; set; }
        public DbSet<MPMUSTERICEKHAR> MPMUSTERICEKHAR { get; set; }
        public DbSet<MPMUSTERICEKNO> MPMUSTERICEKNO { get; set; }
        public DbSet<MPMUSTERICEKSB> MPMUSTERICEKSB { get; set; }
        public DbSet<MPMUSTERISENETHAR> MPMUSTERISENETHAR { get; set; }
        public DbSet<MPMUSTERISENETNO>  MPMUSTERISENETNO { get; set; }
        public DbSet<MPMUSTERISENETSB>  MPMUSTERISENETSB { get; set; }
        public DbSet<MPFIRMACEKHAR> MPFIRMACEKHAR { get; set; }
        public DbSet<MPFIRMACEKNO>  MPFIRMACEKNO { get; set; }
        public DbSet<MPFIRMACEKSB>  MPFIRMACEKSB { get; set; }
        public DbSet<MPFIRMASENETHAR> MPFIRMASENETHAR { get; set; }
        public DbSet<MPFIRMASENETNO>  MPFIRMASENETNO { get; set; }
        public DbSet<MPFIRMASENETSB>  MPFIRMASENETSB { get; set; }
        public DbSet<MPBANKA> MPBANKA { get; set; }
        public DbSet<MPBANKASUBE> MPBANKASUBE { get; set; }
        public DbSet<MPBANKAHESAP> MPBANKAHESAP { get; set; }
        public DbSet<MPHESAPHAREKET> MPHESAPHAREKET { get; set; }
        public DbSet<MPKREDIKART> MPKREDIKART { get; set; }
        public DbSet<MPSERIHAR> MPSERIHAR { get; set; }
        public DbSet<MPCARIALTHESCARI> MPCARIALTHESCARI { get; set; }
        public DbSet<MPSIPARISKASAHAR> MPSIPARISKASAHAR { get; set; }
        public DbSet<MPSTOKRESIM> MPSTOKRESIM { get; set; }
        public DbSet<MPCARIRESIM> MPCARIRESIM { get; set; }
        public DbSet<MPCARIDOKUMAN> MPCARIDOKUMAN { get; set; }
        public DbSet<MPCARIHAR> MPCARIHAR { get; set; }
        public DbSet<MPCARIALTHES> MPCARIALTHES { get; set; }
        public DbSet<MPCARIKART> MPCARIKART { get; set; }
        public DbSet<MPSEVKADRES> MPSEVKADRES { get; set; }
        public DbSet<MPCARIYETKILI> MPCARIYETKILI { get; set; }
        public DbSet<MPSTOKSEVKİYATLİST> MPSTOKSEVKİYATLİST { get; set; }
        public DbSet<MPSIPARISSEVKEMRIHAR> MPSIPARISSEVKEMRIHAR { get; set; }
        public DbSet<MPDEPOEMIR> MPDEPOEMIR { get; set; }
        public DbSet<MPSTOK> MPSTOK { get; set; }
        public DbSet<MPSTOKHAR> MPSTOKHAR { get; set; }
        public DbSet<MPDEPO> MPDEPO { get; set; }
        public DbSet<MPDEPOCEKILIST> MPDEPOCEKILIST { get; set; }
        public DbSet<MPHIZMET> MPHIZMET { get; set; }
        public DbSet<MPHIZMETHAR> MPHIZMETHAR { get; set; }
        public DbSet<MPHIZMETKATEGORI> MPHIZMETKATEGORI { get; set; }
        public DbSet<MPSTOKMARKA> MPSTOKMARKA { get; set; }
        public DbSet<MPSTOKOLCUBR> MPSTOKOLCUBR { get; set; }
        public DbSet<MPSTOKFIYAT> MPSTOKFIYAT { get; set; }
        public DbSet<MPSTOKFIYATHAR> MPSTOKFIYATHAR { get; set; }
        public DbSet<MPARACLAR> MPARACLAR { get; set; }
        public DbSet<MPARAC> MPARAC { get; set; }
        public DbSet<MPSOFOR> MPSOFOR { get; set; }
        public DbSet<MPARACROTA> MPARACROTA { get; set; }
        public DbSet<MPARACMODEL> MPARACMODEL { get; set; }
        public DbSet<MPARACRESIM> MPARACRESIM { get; set; }
        public DbSet<MPARACSIGORTARESIM> MPARACSIGORTARESIM { get; set; }
        public DbSet<MPARACKASKORESIM> MPARACKASKORESIM { get; set; }
        public DbSet<MPARACRUHSATRESIM> MPARACRUHSATRESIM { get; set; }
        public DbSet<MPPERSONEL> MPPERSONEL { get; set; }
        public DbSet<MPPERSONELBANKA> MPPERSONELBANKA { get; set; }
        public DbSet<MPPERSONELAVANS> MPPERSONELAVANS { get; set; }
        public DbSet<MPPERSONELDEPARTMAN> MPPERSONELDEPARTMAN { get; set; }
        public DbSet<MPPERSONELGOREV> MPPERSONELGOREV { get; set; }
        public DbSet<MPPERSONELZIMMET> MPPERSONELZIMMET { get; set; }
        public DbSet<MPPERSONELIZIN> MPPERSONELIZIN { get; set; }
        public DbSet<MPPERSONELBELGE> MPPERSONELBELGE { get; set; }
        public DbSet<MPSTOKSAYIM> MPSTOKSAYIM { get; set; }
        public DbSet<MPSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
        public DbSet<MPOLCUBR> MPOLCUBR { get; set; }
        public DbSet<MPSTOKKATEGORI> MPSTOKKATEGORI { get; set; }
        public DbSet<MPSIPARIS> MPSIPARIS { get; set; }
        public DbSet<MPSIPARISDETAY> MPSIPARISDETAY { get; set; }
        public DbSet<MPDEPOTRANSFER> MPDEPOTRANSFER { get; set; }
        public DbSet<MPDEPOTRANSFERHAR> MPDEPOTRANSFERHAR { get; set; } 
        public DbSet<MPSTOKMALKABULLIST> MPSTOKMALKABULLIST { get; set; }
        public DbSet<MPSTOKKASA> MPSTOKKASA { get; set; }
        public DbSet<MPIRSALIYE> MPIRSALIYE { get; set; } 
        public DbSet<MPIRSALIYESIPARISDETAYILISKI> MPIRSALIYESIPARISDETAYILISKI { get; set; }
        public DbSet<MPIRSALIYEDETAY> MPIRSALIYEDETAY { get; set; }
        public DbSet<MPSATINALMAMALKABULEMRIHAR> MPSATINALMAMALKABULEMRIHAR { get; set; }
        public DbSet<MPPARABIRIM> MPPARABIRIM { get; set; }
        public DbSet<MPKASA> MPKASA { get; set; }
        public DbSet<MPKASAHAR> MPKASAHAR { get; set; }
        public DbSet<MPSTOKKASAHAR> MPSTOKKASAHAR { get; set; }
        public DbSet<MPFATURA> MPFATURA { get; set; }
        public DbSet<MPFATURADETAY> MPFATURADETAY { get; set; }
        public DbSet<MPSTOKKASAMARKA> MPSTOKKASAMARKA { get; set; }
        public DbSet<MPSERI> MPSERI { get; set; }
        public DbSet<MPGELENEFATURA> MPGELENEFATURA { get; set; }
        public DbSet<MPMUKELLEFLISTESI> MPMUKELLEFLISTESI { get; set; }
        public DbSet<MPKASAPARAMS> MPKASAPARAMS { get; set; }
        public DbSet<MPDESTEKSERVİS> MPDESTEKSERVISS { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=213.238.167.117;Database=MEYPAK;User Id=sa;Password=sapass_1;");
        //    }
        //}

        //       protected override void OnModelCreating(ModelBuilder modelBuilder)
        //       {
        //           #region Stok_Navigation_AutoInclude

        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKOLCUBR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        ////           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKOLCUBR).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.OLCUBRID);
        ////           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.BIRIMID);
        ////           modelBuilder.Entity<MPSTOKSAYIM>().HasMany(x => x.MPSTOKSAYIMHAR).WithOne(x => x.MPSTOKSAYIM).HasForeignKey(x => x.STOKSAYIMID);
        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKFIYATLISTHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        ////           modelBuilder.Entity<MPSIPARIS>().HasMany(x => x.MPSIPARISDETAY).WithOne(x => x.MPSIPARIS).HasForeignKey(x => x.SIPARISID);
        ////           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKSEVKİYATLİST).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.BIRIMID);
        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKSEVKİYATLİST).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);
        ////           modelBuilder.Entity<MPSIPARIS>().HasMany(x => x.MPIRSALIYE).WithOne(x => x.MPSIPARIS).HasForeignKey(x => x.SIPARISID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPSIPARISDETAY>().HasMany(x => x.MPSTOKSEVKİYATLİST).WithOne(x => x.MPSIPARISDETAY).HasForeignKey(x => x.SIPARISDETAYID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPSIPARIS>().HasMany(x => x.MPDEPOEMIR).WithOne(x => x.MPSIPARIS).HasForeignKey(x => x.SIPARISID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPOLCUBR>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPOLCUBR).HasForeignKey(x => x.BIRIMID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPDEPOEMIR>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPDEPOEMIR).HasForeignKey(x => x.EMIRID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPSIPARISDETAY>().HasMany(x => x.MPSTOKMALKABULLIST).WithOne(x => x.MPSIPARISDETAY).HasForeignKey(x => x.SIPARISDETAYID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSIPARISDETAY).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID).OnDelete(DeleteBehavior.Restrict);

        ////           modelBuilder.Entity<MPIRSALIYESIPARISDETAYILISKI>().HasKey(sc => new { sc.IRSALIYEDETAYID, sc.SIPARISDETAYID });

        ////           modelBuilder.Entity<MPIRSALIYESIPARISDETAYILISKI>()
        ////               .HasOne<MPIRSALIYEDETAY>(sc => sc.MPIRSALIYEDETAY)
        ////               .WithMany(s => s.MPIRSALIYESIPARISDETAYILISKI)
        ////               .HasForeignKey(sc => sc.IRSALIYEDETAYID).OnDelete(DeleteBehavior.NoAction);
        ////           modelBuilder.Entity<MPIRSALIYESIPARISDETAYILISKI>()
        ////               .HasOne<MPSIPARISDETAY>(sc => sc.MPSIPARISDETAY)
        ////               .WithMany(s => s.MPIRSALIYESIPARISDETAYILISKI)
        ////               .HasForeignKey(sc => sc.SIPARISDETAYID).OnDelete(DeleteBehavior.NoAction);

        ////           modelBuilder.Entity<MPDEPOEMIRSIPARISKALEMILISKI>().HasKey(sc => new { sc.DEPOEMIRID, sc.SIPARISDETAYID });

        ////           modelBuilder.Entity<MPDEPOEMIRSIPARISKALEMILISKI>()
        ////               .HasOne<MPSIPARISDETAY>(sc => sc.MPSIPARISDETAY)
        ////               .WithMany(s => s.MPDEPOEMIRSIPARISKALEMILISKI)
        ////               .HasForeignKey(sc => sc.SIPARISDETAYID).OnDelete(DeleteBehavior.Restrict);
        ////           modelBuilder.Entity<MPDEPOEMIRSIPARISKALEMILISKI>()
        ////               .HasOne<MPDEPOEMIR>(sc => sc.MPDEPOEMIR)
        ////               .WithMany(s => s.MPDEPOEMIRSIPARISKALEMILISKI)
        ////               .HasForeignKey(sc => sc.DEPOEMIRID).OnDelete(DeleteBehavior.Restrict);


        ////           modelBuilder.Entity<MPSTOK>().HasMany(x => x.MPSTOKFIYATLISTHAR).WithOne(x => x.MPSTOK).HasForeignKey(x => x.STOKID);

        ////           modelBuilder.Entity<MPSTOK>()
        ////  .Navigation(b => b.MPSIPARISDETAY)
        ////  .UsePropertyAccessMode(PropertyAccessMode.Property);

        ////           modelBuilder.Entity<MPSTOK>()
        ////     .Navigation(b => b.MPSTOKOLCUBR)
        ////     .UsePropertyAccessMode(PropertyAccessMode.Property);
        ////           modelBuilder.Entity<MPSTOK>()
        ////   .Navigation(b => b.MPSTOKHAR)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);
        ////           modelBuilder.Entity<MPSTOK>()
        ////   .Navigation(b => b.MPSTOKSAYIMHAR)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);

        ////           modelBuilder.Entity<MPSTOKFIYATLIST>()
        ////   .Navigation(b => b.MPSTOKFIYATLISTHAR)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);
        ////           modelBuilder.Entity<MPSTOK>()
        ////   .Navigation(b => b.MPSTOKFIYATLISTHAR)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);
        ////           modelBuilder.Entity<MPSTOK>()
        ////   .Navigation(b => b.MPSTOKSEVKİYATLİST)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);
        ////           modelBuilder.Entity<MPSTOKOLCUBR>()
        ////   .Navigation(b => b.MPOLCUBR)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);

        ////           modelBuilder.Entity<MPOLCUBR>()
        ////   .Navigation(b => b.MPSTOKSAYIMHAR)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);

        ////           modelBuilder.Entity<MPSTOKSAYIM>()
        ////   .Navigation(b => b.MPSTOKSAYIMHAR)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);


        ////           modelBuilder.Entity<MPSIPARIS>()
        ////   .Navigation(b => b.MPSIPARISDETAY)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);

        ////           modelBuilder.Entity<MPOLCUBR>()
        ////   .Navigation(b => b.MPSTOKSEVKİYATLİST)
        ////   .UsePropertyAccessMode(PropertyAccessMode.Property);
        ////           modelBuilder.Entity<MPOLCUBR>()
        ////  .Navigation(b => b.MPSTOKOLCUBR)
        ////  .UsePropertyAccessMode(PropertyAccessMode.Property);

        ////           modelBuilder.Entity<MPSIPARISDETAY>()
        ////.Navigation(b => b.MPSTOKSEVKİYATLİST)
        ////.UsePropertyAccessMode(PropertyAccessMode.Property);







        //           ////modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKOLCUBR).();
        //           //modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKMALKABULLIST).AutoInclude();
        //           //modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKSAYIMHAR).AutoInclude();
        //           //modelBuilder.Entity<MPOLCUBR>().Navigation(x => x.MPSTOKSEVKİYATLİST).AutoInclude();

        //           //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSIPARISDETAY).AutoInclude();
        //           //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKFIYATLISTHAR).AutoInclude();
        //           //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKHAR).AutoInclude();
        //           //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKMALKABULLIST).AutoInclude();
        //           //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKOLCUBR).AutoInclude();
        //           //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKSAYIMHAR).AutoInclude();
        //           //modelBuilder.Entity<MPSTOK>().Navigation(x => x.MPSTOKSEVKİYATLİST).AutoInclude();

        //           //modelBuilder.Entity<MPSTOKFIYATLIST>().Navigation(x => x.MPSTOKFIYATLISTHAR).AutoInclude();

        //           //modelBuilder.Entity<MPSTOKFIYATLISTHAR>().Navigation(x => x.MPSTOK).AutoInclude();
        //           //modelBuilder.Entity<MPSTOKFIYATLISTHAR>().Navigation(x => x.MPSTOKFIYATLIST).AutoInclude();

        //           //modelBuilder.Entity<MPSTOKHAR>().Navigation(x => x.MPSTOK).AutoInclude();

        //           //modelBuilder.Entity<MPSTOKSAYIM>().Navigation(x => x.MPSTOKSAYIMHAR).AutoInclude();

        //           //modelBuilder.Entity<MPSTOKSAYIMHAR>().Navigation(x => x.MPSTOK).AutoInclude();
        //           ////modelBuilder.Entity<MPSTOKSAYIMHAR>().Navigation(x => x.MPOLCUBR).AutoInclude();
        //           //modelBuilder.Entity<MPSTOKSAYIMHAR>().Navigation(x => x.MPSTOKSAYIM).AutoInclude();

        //           #endregion

        //       }


        //           OnModelCreatingPartial(modelBuilder);

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
