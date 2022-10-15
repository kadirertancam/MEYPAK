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
    public interface IStokFiyatListServis:IGenericServis<PocoSTOKFIYATLIST>
    {
        public PocoSTOKFIYATLIST EkleyadaGuncelle(PocoSTOKFIYATLIST entity);

        public List<PocoStokFiyatList> PocoStokFiyatListesi();
    }
}
