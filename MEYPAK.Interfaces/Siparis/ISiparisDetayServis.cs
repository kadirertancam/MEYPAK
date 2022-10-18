using MEYPAK.Entity.Models.SIPARIS;

namespace MEYPAK.Interfaces.Siparis
{
    public interface ISiparisDetayServis:IGenericServis<MPSIPARISDETAY>
    {
        public Durum EkleyadaGuncelle(MPSIPARISDETAY entity);
    }
}
