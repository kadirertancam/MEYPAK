using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Siparis
{
    public interface ISiparisServis:IGenericServis<PocoSIPARIS>
    {
        public Durum EkleyadaGuncelle(PocoSIPARIS entity);
    }
}
