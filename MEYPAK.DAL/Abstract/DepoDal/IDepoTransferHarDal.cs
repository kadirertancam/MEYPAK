using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoTransferHarDal:IGeneric<MPDEPOTRANSFERHAR>
    {
        public MPDEPOTRANSFERHAR EkleyadaGuncelle(MPDEPOTRANSFERHAR entity);
    }
}
