using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IDepoCekiListDal:IGeneric<MPDEPOCEKILIST>
    {
       

        public List<MPDEPOCEKILIST> PagingList(int skip, int take);

    }
}
