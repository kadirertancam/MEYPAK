using MEYPAK.Entity.Models.SIPARIS;

namespace MEYPAK.DAL.Abstract.SiparisDal
{
    public interface ISiparisSevkEmriHarDal:IGeneric<MPSIPARISSEVKEMRIHAR>
    {
        public MPSIPARISSEVKEMRIHAR EkleyadaGuncelle(MPSIPARISSEVKEMRIHAR entity);
    }
}
