using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokOlcuBrServis:IGenericServis<MPSTOKOLCUBR>
    {
        public Durum EkleyadaGuncelle(MPSTOKOLCUBR entity);
    }
}
