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
    public class StokSayimManager : IStokSayimServis
    {
        IStokSayimDal _stokSayimDal;
        public StokSayimManager(IStokSayimDal stokSayimDal)
        {
            _stokSayimDal = stokSayimDal;
        }

        public Durum Ekle(MPSTOKSAYIM entity)
        {
            return _stokSayimDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPSTOKSAYIM entity)
        {
            return _stokSayimDal.EkleyadaGuncelle(entity);
        }

        public List<MPSTOKSAYIM> Getir(string entity)
        {
            return _stokSayimDal.Getir(entity);
        }

        public List<MPSTOKSAYIM> Getir(Expression<Func<MPSTOKSAYIM, bool>> expression)
        {
            return _stokSayimDal.Getir(expression);
        }

        public List<MPSTOKSAYIM> Guncelle(MPSTOKSAYIM entity)
        {
            return _stokSayimDal.Guncelle(entity);
        }

        public List<MPSTOKSAYIM> Listele()
        {
            return _stokSayimDal.Listele();
        }

        public bool Sil(Expression<Func<MPSTOKSAYIM, bool>> predicate)
        {
            return _stokSayimDal.Sil(predicate);
        }

        public bool Sil(List<MPSTOKSAYIM> entity)
        {
            return _stokSayimDal.Sil(entity);
        }
    }
}
