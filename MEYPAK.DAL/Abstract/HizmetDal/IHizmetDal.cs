using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.HizmetDal
{
    public interface IHizmetDal : IGeneric<MPHIZMET>
    {
  

        public List<MPHIZMET> PagingList(int skip, int take);

    }
}
