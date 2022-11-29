using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokFiyatServis : IGenericServis<PocoSTOKFIYAT>
    {
        public PocoSTOKFIYAT EkleyadaGuncelle(PocoSTOKFIYAT entity);

        public List<PocoSTOKFIYAT> PagingList(int skip, int take);
    }

}
