using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.SiparisDal
{
    public interface ISiparisKasaHarDal:IGeneric<MPSIPARISKASAHAR>
    {
        public MPSIPARISKASAHAR EkleyadaGuncelle(MPSIPARISKASAHAR entity);
    }
}
