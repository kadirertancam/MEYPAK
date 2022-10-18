using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokFiyatListHarManager : BaseManager<MPSTOKFIYATLISTHAR>,IStokFiyatListHarServis
    {
        IStokFiyatListHarDal _stokFiyatListDal;
        public StokFiyatListHarManager(IStokFiyatListHarDal generic) : base(generic)
        {
            this._stokFiyatListDal = generic;
        }

        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity)
        {
            return _stokFiyatListDal.EkleyadaGuncelle(entity);
        }
        void Sil(int id)
        {
            _stokFiyatListDal.Sil(id);
        }
    }
}
