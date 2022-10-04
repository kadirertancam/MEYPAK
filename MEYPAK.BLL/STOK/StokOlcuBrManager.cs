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
    public class StokOlcuBrManager : IStokOlcuBrServis
    {
        IStokOlcuBrDal _stokOlcuBrDal;
        public StokOlcuBrManager(IStokOlcuBrDal stokolcuBrDal)
        {
            this._stokOlcuBrDal = stokolcuBrDal;    
        }
        public Durum Ekle(MPSTOKOLCUBR entity)
        {
           return _stokOlcuBrDal.Ekle(entity);

        }

        public Durum EkleyadaGuncelle(MPSTOKOLCUBR entity)
        {
            return _stokOlcuBrDal.EkleyadaGuncelle(entity);
        }

        public List<MPSTOKOLCUBR> Getir(string entity)
        {
            return _stokOlcuBrDal.Getir(entity);
        }

        public List<MPSTOKOLCUBR> Getir(Expression<Func<MPSTOKOLCUBR, bool>> expression)
        {
            return _stokOlcuBrDal.Getir(expression);
        }

        public List<MPSTOKOLCUBR> Guncelle(MPSTOKOLCUBR entity)
        {
            return  _stokOlcuBrDal.Guncelle(entity);
        }

        public List<MPSTOKOLCUBR> Listele()
        {
            return _stokOlcuBrDal.Listele();
        }

        public bool Sil(Expression<Func<MPSTOKOLCUBR, bool>> predicate)
        {
            return _stokOlcuBrDal.Sil(predicate);
        }

        public bool Sil(List<MPSTOKOLCUBR> entity)
        {
            return _stokOlcuBrDal.Sil(entity);
        }
    }
}
