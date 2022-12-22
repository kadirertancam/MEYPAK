using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoEmirDal:IGeneric<MPDEPOEMIR>
    {
        

        public List<MPDEPOEMIR> PagingList(int skip, int take);

    }
}
