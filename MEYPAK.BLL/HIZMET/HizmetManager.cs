using MEYPAK.DAL;
using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Hizmet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.HIZMET
{
    public class HizmetManager : IHizmetServis
    {
        IHizmetDal _hizmetDal;
        public HizmetManager(IHizmetDal hizmetDal)
        {
            _hizmetDal = hizmetDal;
        }
        public MPHIZMET Ekle(MPHIZMET entity)
        {
            return _hizmetDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPHIZMET entity)
        {
            throw new NotImplementedException();
        }

       

        public List<MPHIZMET> Getir(Expression<Func<MPHIZMET, bool>> expression)
        {
            return _hizmetDal.Getir(expression);
        }

        public Durum Guncelle(MPHIZMET entity)
        {
            return _hizmetDal.Guncelle(entity);
        }

        public List<MPHIZMET> Listele()
        {
            return _hizmetDal.Listele();
        }

        public bool Sil(Expression<Func<MPHIZMET, bool>> predicate)
        {
            return _hizmetDal.Sil(predicate);
        }

        public bool Sil(List<MPHIZMET> entity)
        {
            return _hizmetDal.Sil(entity);
        }
    }
}
