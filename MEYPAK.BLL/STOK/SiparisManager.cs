using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Siparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class SiparisManager : BaseManager<MPSIPARIS>, ISiparisServis
    {
        ISiparisDal siparisDal;
        public SiparisManager(ISiparisDal generic) : base(generic)
        {
            siparisDal = generic;
        }

        public Durum EkleyadaGuncelle(MPSIPARIS entity)
        {
            return siparisDal.EkleyadaGuncelle(entity);
        }
    }
}
