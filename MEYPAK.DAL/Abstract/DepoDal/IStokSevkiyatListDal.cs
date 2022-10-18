using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IStokSevkiyatListDal:IGeneric<MPSTOKSEVKİYATLİST>
    {
        public Durum EkleyadaGuncelle(MPSTOKSEVKİYATLİST entity);
        public void OnYukle();
    }
}
