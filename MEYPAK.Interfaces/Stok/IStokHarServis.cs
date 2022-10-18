using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokHarServis:IGenericServis<MPSTOKHAR>
    {
        List<PocoStokHareketListesi> PocoStokHareketListesi(int id);
        public Durum EkleyadaGuncelle(MPSTOKHAR entity);
    }
}
