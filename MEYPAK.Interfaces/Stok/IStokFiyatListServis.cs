using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokFiyatListServis:IGenericServis<MPSTOKFIYATLIST>
    {
        public MPSTOKFIYATLIST EkleyadaGuncelle(MPSTOKFIYATLIST entity);

        public List<PocoStokFiyatList> PocoStokFiyatListesi();
    }
}
