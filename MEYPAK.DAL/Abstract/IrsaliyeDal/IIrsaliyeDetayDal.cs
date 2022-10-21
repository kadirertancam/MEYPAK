using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.IrsaliyeDal
{
    public interface IIrsaliyeDetayDal:IGeneric<MPIRSALIYEDETAY>
    {

        public MPIRSALIYEDETAY EkleyadaGuncelle(MPIRSALIYEDETAY entity);
    }
}
