using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Siparis
{
    public interface ISiparisDetayServis:IGenericServis<PocoSIPARISDETAY>
    {
        public PocoSIPARISDETAY EkleyadaGuncelle(PocoSIPARISDETAY entity);

        public List<PocoSIPARISDETAY> PagingList(int skip, int take);

    }
}
