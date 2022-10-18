using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokSayimHarServis:IGenericServis<MPSTOKSAYIMHAR>
    {
        public Durum EkleyadaGuncelle(MPSTOKSAYIMHAR entity);
    }
}
