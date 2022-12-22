using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoTransferHarDal:IGeneric<MPDEPOTRANSFERHAR>
    {

        public List<MPDEPOTRANSFERHAR> PagingList(int skip, int take);

    }
}
