using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokFiyatHarServis : IGenericServis<PocoSTOKFIYATHAR>
    {
        
            public PocoSTOKFIYATHAR EkleyadaGuncelle(PocoSTOKFIYATHAR entity);

            public List<PocoSTOKFIYATHAR> PagingList(int skip, int take);
    }
}

