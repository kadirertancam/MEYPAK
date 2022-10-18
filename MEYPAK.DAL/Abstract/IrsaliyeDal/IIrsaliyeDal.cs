using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.IrsaliyeDal
{
    public interface IIrsaliyeDal : IGeneric<MPIRSALIYE>
    {

        public Durum EkleyadaGuncelle(MPIRSALIYE entity);
    }
}
