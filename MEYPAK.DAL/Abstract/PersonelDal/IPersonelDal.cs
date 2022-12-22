using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.PersonelDal
{
    public interface IPersonelDal:IGeneric<MPPERSONEL>
    {

        public List<MPPERSONEL> PagingList(int skip, int take);

    }
}
