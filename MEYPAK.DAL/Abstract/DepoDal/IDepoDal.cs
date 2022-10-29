using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoDal : IGeneric<MPDEPO>
    {
        public MPDEPO EkleyadaGuncelle(MPDEPO entity);

        public List<MPDEPO> PagingList(int skip, int take);

    }
}
