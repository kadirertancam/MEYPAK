using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokHarServis:IGenericServis<PocoSTOKHAR>
    {
        List<PocoStokHareketListesi> PocoStokHareketListesi(int id);
        public PocoSTOKHAR EkleyadaGuncelle(PocoSTOKHAR entity);

        public List<PocoSTOKHAR> PagingList(int skip, int take);
    }
}
