using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokDal : IGeneric<MPSTOK>
    {
        public MPSTOK EkleyadaGuncelle(MPSTOK entity);

        public IQueryable<MPSTOK> Listee();
    }
}
