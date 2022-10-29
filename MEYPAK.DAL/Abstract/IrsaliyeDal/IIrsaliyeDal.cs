using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.IrsaliyeDal
{
    public interface IIrsaliyeDal : IGeneric<MPIRSALIYE>
    {

        public MPIRSALIYE EkleyadaGuncelle(MPIRSALIYE entity);

        public List<MPIRSALIYE> PagingList(int skip, int take);

    }
}
