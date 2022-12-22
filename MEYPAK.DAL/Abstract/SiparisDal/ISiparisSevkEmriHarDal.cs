using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;

namespace MEYPAK.DAL.Abstract.SiparisDal
{
    public interface ISiparisSevkEmriHarDal:IGeneric<MPSIPARISSEVKEMRIHAR>
    {

        public List<MPSIPARISSEVKEMRIHAR> PagingList(int skip, int take);

    }
}
