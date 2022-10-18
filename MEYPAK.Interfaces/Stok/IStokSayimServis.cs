using MEYPAK.Entity.Models.STOK;


namespace MEYPAK.Interfaces.Stok
{
    public interface IStokSayimServis:IGenericServis<MPSTOKSAYIM>
    {
        public Durum EkleyadaGuncelle(MPSTOKSAYIM entity);
    }
}
