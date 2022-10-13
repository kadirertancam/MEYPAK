using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokFiyatListDal:IGeneric<MPSTOKFIYATLIST>
    {
        public MPSTOKFIYATLIST EkleyadaGuncelle(MPSTOKFIYATLIST entity);

        List<PocoStokFiyatList> PocoStokFiyatListesi();
    }
}
