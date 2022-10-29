using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokKasaServis:IGenericServis<PocoSTOKKASA>
    {
        public PocoSTOKKASA EkleyadaGuncelle(PocoSTOKKASA entity);

        public List<PocoSTOKKASA> PagingList(int skip, int take);
    }
}
