using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models;
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
    public class KategoriManager :BaseManager<MPKATEGORI>, IKategoriServis
    {
        IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal generic) : base(generic)
        {
            _kategoriDal = generic;
        }

        public Durum EkleyadaGuncelle(MPKATEGORI entity)
        {
            return _kategoriDal.EkleyadaGuncelle(entity);
        }

       
    }
}
