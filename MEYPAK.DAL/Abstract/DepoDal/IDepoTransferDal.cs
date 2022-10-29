using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoTransferDal:IGeneric<MPDEPOTRANSFER>
    {
        public MPDEPOTRANSFER EkleyadaGuncelle(MPDEPOTRANSFER entity);

        List<PocoDepolarArasıTransfer> PocoDepolarArasıTransferListesi();

        public List<MPDEPOTRANSFER> PagingList(int skip, int take);

    }
}
