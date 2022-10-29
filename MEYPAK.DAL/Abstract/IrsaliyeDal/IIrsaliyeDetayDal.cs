using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.IrsaliyeDal
{
    public interface IIrsaliyeDetayDal:IGeneric<MPIRSALIYEDETAY>
    {

        public MPIRSALIYEDETAY EkleyadaGuncelle(MPIRSALIYEDETAY entity);

        public List<MPIRSALIYEDETAY> PagingList(int skip, int take);

    }
}
