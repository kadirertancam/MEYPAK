using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokMarkaServis:IGenericServis<MPSTOKMARKA>
    {
        public Durum EkleyadaGuncelle(MPSTOKMARKA entity);
    }
}
