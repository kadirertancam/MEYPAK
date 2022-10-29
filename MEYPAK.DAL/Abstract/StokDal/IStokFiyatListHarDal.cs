using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokFiyatListHarDal:IGeneric<MPSTOKFIYATLISTHAR>
    {
        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity);

        public List<MPSTOKFIYATLISTHAR> PagingList(int skip, int take);

    }
}
