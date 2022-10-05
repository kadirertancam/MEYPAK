using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.SiparisDal
{
    public interface ISiparisDetayDal:IGeneric<MPSIPARISDETAY>
    {
        public Durum EkleyadaGuncelle(MPSIPARISDETAY entity);
    }
}
