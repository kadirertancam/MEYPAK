using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoServis : IGenericServis<MPDEPO>
    {
        public Durum EkleyadaGuncelle(MPDEPO entity);
    }
}
