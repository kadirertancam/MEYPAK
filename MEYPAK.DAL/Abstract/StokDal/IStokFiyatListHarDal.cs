using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokFiyatListHarDal:IGeneric<MPSTOKFIYATLISTHAR>
    {
        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity);

        public void Sil(int id);
    }
}
