using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokServis:IGenericServis<MPSTOK>
    {
        public Durum EkleyadaGuncelle(MPSTOK entity);
    }
}
