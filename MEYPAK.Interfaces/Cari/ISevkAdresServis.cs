using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Cari
{
    public interface ISevkAdresServis:IGenericServis<PocoSEVKADRES>
    {
        public PocoSEVKADRES EkleyadaGuncelle(PocoSEVKADRES entity);
    }
}
