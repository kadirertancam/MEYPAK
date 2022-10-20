using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokHarDal : IGeneric<MPSTOKHAR>
    {
        List<PocoStokHareketListesi> PocoStokHareketListesi(int id);
        public MPSTOKHAR EkleyadaGuncelle(MPSTOKHAR entity);
        public void Sil(int id);
    }
}
