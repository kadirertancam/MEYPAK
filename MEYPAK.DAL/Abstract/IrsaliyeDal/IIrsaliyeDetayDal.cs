using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.IrsaliyeDal
{
    public interface IIrsaliyeDetayDal:IGeneric<MPIRSALIYEDETAY>
    {

        public Durum EkleyadaGuncelle(MPIRSALIYEDETAY entity);
    }
}
