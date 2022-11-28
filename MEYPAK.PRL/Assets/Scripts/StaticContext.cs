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
        
        private static MEYPAKContext context = NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        public static IStokServis _stokServis;
        public static IStokSevkiyatListServis _stokSevkiyatListServis ;
        public static ISiparisDetayServis _siparisDetayServis ;
        public static ISiparisServis _siparisServis ;
        public static IDepoEmirServis _depoEmirServis ;
        public static ISiparisSevkEmriHarServis _siparisSevkEmriHarServis ;
        public static IOlcuBrServis _olcuBrServis ;
        public static IStokOlcuBrServis _stokOlcuBrServis ;
        public static IDepoServis _depoServis ; 
        
        public static IStokMalKabulListServis _stokMalKabulListServis;




    }
}
