using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Interfaces.Hizmet
{
    public interface IHizmetServis : IGenericServis<MPHIZMET>
    {
        public Durum EkleyadaGuncelle(MPHIZMET entity);
    }
}
