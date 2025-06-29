using DevExpress.XtraEditors;
using MEYPAK.PRL.ARA�LAR;
using MEYPAK.PRL.ARACLAR;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.BANKA;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.CARI.Raporlar;
using MEYPAK.PRL.CEKSENET;
using MEYPAK.PRL.DEKONT;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.E_ISLEMLER;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.KASA;
using MEYPAK.PRL.MOBILIZ;
using MEYPAK.PRL.PARAMETRELER;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using MEYPAK.PRL.STOK.Raporlar;
using MEYPAK.PRL.STOK.StokKasa;
using Microsoft.EntityFrameworkCore;
using static MEYPAK.PRL.Assets.NinjectFactory;

namespace MEYPAK.PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration. 
           // WindowsFormsSettings.ForceDirectXPaint();

            DependencyModule a = new DependencyModule();
            NinjectFactory.CompositionRoot.Initialize(a);
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.Run(new LoginScreen());
        }
        

        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
        }
    }
}