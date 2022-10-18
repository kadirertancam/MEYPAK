using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokKategoriManager :BaseManager<MPSTOKKATEGORI>, IStokKategoriServis
    {
        IStokKategoriDal _kategoriDal;

        public StokKategoriManager(IStokKategoriDal generic) : base(generic)
        {
            _kategoriDal = generic;
        }

        public Durum EkleyadaGuncelle(MPSTOKKATEGORI entity)
        {
            return _kategoriDal.EkleyadaGuncelle(entity);
        }

       
    }
}
