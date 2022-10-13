using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces.Siparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.SIPARIS
{
    public class SiparisSevkEmriHarManager:BaseManager<MPSIPARISSEVKEMRIHAR>,ISiparisSevkEmriHarServis
    {
        ISiparisSevkEmriHarDal _siparisSevkEmriHarDal;

        public SiparisSevkEmriHarManager(ISiparisSevkEmriHarDal generic) : base(generic)
        {
            _siparisSevkEmriHarDal = generic;
        }
    }
}
