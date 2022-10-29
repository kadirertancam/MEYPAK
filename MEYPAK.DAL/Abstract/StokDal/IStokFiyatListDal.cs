using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokFiyatListDal:IGeneric<MPSTOKFIYATLIST>
    {
        public MPSTOKFIYATLIST EkleyadaGuncelle(MPSTOKFIYATLIST entity);
        public List<MPSTOKFIYATLIST> PagingList(int skip, int take);

        List<PocoStokFiyatList> PocoStokFiyatListesi();
    }
}
