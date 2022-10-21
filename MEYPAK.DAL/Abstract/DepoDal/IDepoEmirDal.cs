using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoEmirDal:IGeneric<MPDEPOEMIR>
    {
        public MPDEPOEMIR EkleyadaGuncelle(MPDEPOEMIR entity);
    }
}
