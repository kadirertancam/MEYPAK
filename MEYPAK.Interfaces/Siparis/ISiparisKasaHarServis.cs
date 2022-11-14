using MEYPAK.Entity.PocoModels.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Siparis
{
    public interface ISiparisKasaHarServis:IGenericServis<PocoSIPARISKASAHAR>
    {
        public PocoSIPARISKASAHAR EkleyadaGuncelle(PocoSIPARISKASAHAR entity);
    }
}
