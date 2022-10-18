using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoTransferHarServis:IGenericServis<MPDEPOTRANSFERHAR>
    {
        public MPDEPOTRANSFERHAR EkleyadaGuncelle(MPDEPOTRANSFERHAR entity);
    }
}
