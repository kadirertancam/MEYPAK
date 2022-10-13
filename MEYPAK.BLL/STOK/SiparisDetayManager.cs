using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Siparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class SiparisDetayManager : BaseManager<MPSIPARISDETAY>, ISiparisDetayServis
    {
        ISiparisDetayDal siparisDetayDal;
        public SiparisDetayManager(ISiparisDetayDal generic) : base(generic)
        {
            siparisDetayDal = generic;
        }

        public Durum EkleyadaGuncelle(MPSIPARISDETAY entity)
        {
            return siparisDetayDal.EkleyadaGuncelle(entity);
        }
    }
}
