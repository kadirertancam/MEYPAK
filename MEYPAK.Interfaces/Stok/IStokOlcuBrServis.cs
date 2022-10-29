using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokOlcuBrServis:IGenericServis<PocoSTOKOLCUBR>
    {
        public PocoSTOKOLCUBR EkleyadaGuncelle(PocoSTOKOLCUBR entity);

        public List<PocoSTOKOLCUBR> PagingList(int skip, int take);
    }
}
