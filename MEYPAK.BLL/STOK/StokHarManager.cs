using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
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
    public class StokHarManager : IStokHarServis
    {
        IStokHarDal _stokHarDal;
        public StokHarManager(IStokHarDal stokHarDal)
        {
            this._stokHarDal = stokHarDal;
        }

        public Interfaces.Durum Ekle(MPSTOKHAR entity)
        {
            return _stokHarDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPSTOKHAR entity)
        {
            return _stokHarDal.EkleyadaGuncelle(entity);
        }

        public List<MPSTOKHAR> Getir(string entity)
        {
            return _stokHarDal.Getir(entity);
        }

        public List<MPSTOKHAR> Getir(Expression<Func<MPSTOKHAR, bool>> expression)
        {
            return _stokHarDal.Getir(expression);
        }

        public List<MPSTOKHAR> Guncelle(MPSTOKHAR entity)
        {
            return _stokHarDal.Guncelle(entity);
        }

        public List<MPSTOKHAR> Listele()
        {
            return _stokHarDal.Listele();
        }

        public List<PocoStokHareketListesi> PocoStokHareketListesi(int id)
        {
            return _stokHarDal.PocoStokHareketListesi(id);
        }

        public bool Sil(Expression<Func<MPSTOKHAR, bool>> predicate)
        {
            return _stokHarDal.Sil(predicate);
        }

        public bool Sil(List<MPSTOKHAR> entity)
        {
            return _stokHarDal.Sil(entity);
        }
    }
}
