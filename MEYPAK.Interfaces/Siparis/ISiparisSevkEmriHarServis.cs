using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Siparis
{
    public interface ISiparisSevkEmriHarServis:IGenericServis<PocoSIPARISSEVKEMIRHAR>
    {
        public PocoSIPARISSEVKEMIRHAR EkleyadaGuncelle(PocoSIPARISSEVKEMIRHAR entity);

        public List<PocoSIPARISSEVKEMIRHAR> PagingList(int skip, int take);

    }
}
