using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Hizmet
{
    public interface IHizmetServis : IGenericServis<PocoHIZMET>
    {
        public PocoHIZMET EkleyadaGuncelle(PocoHIZMET entity);
    }
}
