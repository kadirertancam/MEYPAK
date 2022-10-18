using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokKategoriServis:IGenericServis<MPSTOKKATEGORI>
    {
        public Durum EkleyadaGuncelle(MPSTOKKATEGORI entity);
    }
}
