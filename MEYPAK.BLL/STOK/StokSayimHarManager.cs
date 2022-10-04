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
    public class StokSayimHarManager : IStokSayimHarServis
    {
        IStokSayimHarDal _stokSayimHarDal;
        public StokSayimHarManager(IStokSayimHarDal stokSayimHarDal)
        {
            _stokSayimHarDal = stokSayimHarDal;
        }

        public Durum Ekle(MPSTOKSAYIMHAR entity)
        {
            return _stokSayimHarDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPSTOKSAYIMHAR entity)
        {
            return _stokSayimHarDal.EkleyadaGuncelle(entity);
        }

        public List<MPSTOKSAYIMHAR> Getir(string entity)
        {
            return _stokSayimHarDal.Getir(entity);
        }

        public List<MPSTOKSAYIMHAR> Getir(Expression<Func<MPSTOKSAYIMHAR, bool>> expression)
        {
            return _stokSayimHarDal.Getir(expression);
        }

        public List<MPSTOKSAYIMHAR> Guncelle(MPSTOKSAYIMHAR entity)
        {
            return _stokSayimHarDal.Guncelle(entity);
        }

        public List<MPSTOKSAYIMHAR> Listele()
        {
            return _stokSayimHarDal.Listele();
        }

        public bool Sil(Expression<Func<MPSTOKSAYIMHAR, bool>> predicate)
        {
            return _stokSayimHarDal.Sil(predicate);
        }

        public bool Sil(List<MPSTOKSAYIMHAR> entity)
        {
            return _stokSayimHarDal.Sil(entity);
        }
    }
}
