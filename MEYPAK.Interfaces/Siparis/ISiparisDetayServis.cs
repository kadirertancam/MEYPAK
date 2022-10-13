using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Siparis
{
    public interface ISiparisDetayServis:IGenericServis<MPSIPARISDETAY>
    {
        public Durum EkleyadaGuncelle(MPSIPARISDETAY entity);
    }
}
