using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Hizmet
{
    public interface IHizmetKategoriServis : IGenericServis<PocoHIZMETKATEGORI>
    {
        public PocoHIZMETKATEGORI EkleyadaGuncelle(PocoHIZMETKATEGORI entity);
    }
}
