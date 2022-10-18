using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokFiyatListManager : BaseManager<MPSTOKFIYATLIST>,IStokFiyatListServis
    {
        IStokFiyatListDal _stokFiyatListDal;
        public StokFiyatListManager(IStokFiyatListDal generic) : base(generic)
        {
            _stokFiyatListDal = generic;
        }

        public MPSTOKFIYATLIST EkleyadaGuncelle(MPSTOKFIYATLIST entity)
        {
            return _stokFiyatListDal.EkleyadaGuncelle(entity);
        }

        public List<PocoStokFiyatList> PocoStokFiyatListesi()
        {
            return _stokFiyatListDal.PocoStokFiyatListesi();
        }
    }
}
