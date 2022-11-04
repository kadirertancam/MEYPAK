using MEYPAK.PRL.Assets;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.MOBILIZ;
using MEYPAK.PRL.PARAMETRELER;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
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
            DependencyModule a = new DependencyModule();
            NinjectFactory.CompositionRoot.Initialize(a);
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.Run(new FSeriTanim());
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