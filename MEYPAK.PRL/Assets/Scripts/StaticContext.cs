using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.SIPARIS;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets.Scripts
{
    public static class StaticContext
    {
        
        private static MEYPAKContext context =new MEYPAKContext();
        public static IStokServis _stokServis = new StokManager(new EFStokRepo(context));
        public static IStokSevkiyatListServis _stokSevkiyatListServis = new StokSevkiyatListManager(new EFStokSevkiyatListRepo(context));
        public static ISiparisDetayServis _siparisDetayServis = new SiparisDetayManager(new EFSiparisDetayRepo(context));
        public static ISiparisServis _siparisServis = new SiparisManager(new EFSiparisRepo(context));
        public static IDepoEmirServis _depoEmirServis = new DepoEmirManager(new EFDepoEmirRepo(context));
        public static ISiparisSevkEmriHarServis _siparisSevkEmriHarServis = new SiparisSevkEmriHarManager(new EFSiparisSevkEmriHarRepo(context));
        public static IOlcuBrServis _olcuBrServis = new OlcuBrManager(new EFOlcuBrRepo(context));
        public static IStokOlcuBrServis _stokOlcuBrServis = new StokOlcuBrManager(new EFStokOlcuBrRepo(context));
        public static IDepoServis _depoServis = new DepoManager(new EFDepoRepo(context));
        public static IStokFiyatListServis _stokFiyatListServis = new StokFiyatListManager(new EFStokFiyatListRepo(context));
        public static IStokMalKabulListServis _stokMalKabulListServis = new StokMalKabulListManager(new EFStokMalKabulList(context));



    }
}
