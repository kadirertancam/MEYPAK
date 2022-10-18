using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Stok
{
    public interface IOlcuBrServis:IGenericServis<MPOLCUBR>
    {
        public Durum EkleyadaGuncelle(MPOLCUBR entity);
    }
}
