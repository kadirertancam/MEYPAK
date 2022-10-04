using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
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
    public class StokManager : IStokServis
    {
        IStokDal _stokDal;

        public StokManager(IStokDal stokDal)
        {
            this._stokDal = stokDal;
        }

        public Interfaces.Durum Ekle(MEYPAK.Entity.Models.MPSTOK entity)
        {
            return _stokDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPSTOK entity)
        {
            return _stokDal.EkleyadaGuncelle(entity);
        }

        public List<MEYPAK.Entity.Models.MPSTOK> Getir(string entity)
        {
            return _stokDal.Getir(entity);
        }

        public List<MPSTOK> Getir(Expression<Func<MPSTOK, bool>> predicate)
        {
            return _stokDal.Getir(predicate);   
        }

        public List<MEYPAK.Entity.Models.MPSTOK> Guncelle(MEYPAK.Entity.Models.MPSTOK entity)
        {
           return _stokDal.Guncelle(entity);
        }

        public List<MEYPAK.Entity.Models.MPSTOK> Listele()
        {
            return _stokDal.Listele();
        }

        public bool Sil(System.Linq.Expressions.Expression<Func<MEYPAK.Entity.Models.MPSTOK, bool>> predicate)
        {
            return _stokDal.Sil(predicate);
        }

        public bool Sil(List<MEYPAK.Entity.Models.MPSTOK> entity)
        {
            return _stokDal.Sil(entity);
        }
    }
}
