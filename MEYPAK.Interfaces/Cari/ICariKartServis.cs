using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Cari
{
    public interface ICariKartServis:IGenericServis<PocoCARIKART>
    {
        public PocoCARIKART EkleyadaGuncelle(PocoCARIKART entity);
    }
}
