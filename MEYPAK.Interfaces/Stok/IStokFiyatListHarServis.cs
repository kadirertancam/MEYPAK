using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokFiyatListHarServis:IGenericServis<MPSTOKFIYATLISTHAR>
    {
        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity);
    }
}
