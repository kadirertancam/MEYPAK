using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokKasaDal:IGeneric<MPSTOKKASA>
    {
       

        public List<MPSTOKKASA> PagingList(int skip, int take);

    }
}
