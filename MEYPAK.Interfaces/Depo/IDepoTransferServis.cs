using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoTransferServis:IGenericServis<MPDEPOTRANSFER>
    {
        public MPDEPOTRANSFER EkleyadaGuncelle(MPDEPOTRANSFER entity);

        public List<PocoDepolarArasıTransfer> PocoDepolarArasıTransferListesi();
    }
}
