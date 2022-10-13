using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
