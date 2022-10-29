using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokKategoriServis:IGenericServis<PocoSTOKKATEGORI>
    {
        public PocoSTOKKATEGORI EkleyadaGuncelle(PocoSTOKKATEGORI entity);

        public List<PocoSTOKKATEGORI> PagingList(int skip, int take);
    }
}
