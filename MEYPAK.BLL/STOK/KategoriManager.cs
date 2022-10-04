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
    public class KategoriManager : IKategoriServis
    {
        IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            this._kategoriDal = kategoriDal;
        }

        public Durum Ekle(MPKATEGORI entity)
        {
            return _kategoriDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPKATEGORI entity)
        {
            return _kategoriDal.EkleyadaGuncelle(entity);
        }

        public List<MPKATEGORI> Getir(string entity)
        {
            return _kategoriDal.Getir(entity);
        }

        public List<MPKATEGORI> Getir(Expression<Func<MPKATEGORI, bool>> predicate)
        {
            return _kategoriDal.Getir(predicate);
        }

        public List<MPKATEGORI> Guncelle(MPKATEGORI entity)
        {
            return _kategoriDal.Guncelle(entity);
        }

        public List<MPKATEGORI> Listele()
        {
            return _kategoriDal.Listele();
        }

        public bool Sil(Expression<Func<MPKATEGORI, bool>> predicate)
        {
            return _kategoriDal.Sil(predicate);
        }

        public bool Sil(List<MPKATEGORI> entity)
        {
            return _kategoriDal.Sil(entity);
        }
    }
}
