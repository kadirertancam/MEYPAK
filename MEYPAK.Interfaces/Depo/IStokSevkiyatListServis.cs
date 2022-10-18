using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.Interfaces.Depo
{
    public interface IStokSevkiyatListServis:IGenericServis<MPSTOKSEVKİYATLİST>
    {
        public Durum EkleyadaGuncelle(MPSTOKSEVKİYATLİST entity);
        public void OnYukle();
    }
}
