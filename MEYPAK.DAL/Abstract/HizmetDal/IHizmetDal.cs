using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.HizmetDal
{
    public interface IHizmetDal : IGeneric<MPHIZMET>
    {
        public Durum EkleyadaGuncelle(MPHIZMET entity);

    }
}
