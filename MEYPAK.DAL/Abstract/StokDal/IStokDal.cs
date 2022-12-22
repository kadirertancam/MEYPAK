using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokDal : IGeneric<MPSTOK>
    {
        

        public List<MPSTOK> PagingList(int skip, int take);


    }
}
