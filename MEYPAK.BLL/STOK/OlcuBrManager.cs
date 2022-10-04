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
    public class OlcuBrManager : IOlcuBrServis
    {
        IOlcuBrDal _olcuBrDal;
        public OlcuBrManager(IOlcuBrDal olcuBrDal)
        {
             _olcuBrDal = olcuBrDal;
        }

        public Durum Ekle(MPOLCUBR entity)
        {
           return _olcuBrDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPOLCUBR entity)
        {
            return _olcuBrDal.EkleyadaGuncelle(entity);
        }

        public List<MPOLCUBR> Getir(string entity)
        {
            return _olcuBrDal.Getir(entity);
        }

        public List<MPOLCUBR> Getir(Expression<Func<MPOLCUBR, bool>> expression)
        {
            return _olcuBrDal.Getir(expression);
        }

        public List<MPOLCUBR> Guncelle(MPOLCUBR entity)
        {
            return _olcuBrDal.Guncelle(entity);
        }

        public List<MPOLCUBR> Listele()
        {
            return _olcuBrDal.Listele();
        }

        public bool Sil(Expression<Func<MPOLCUBR, bool>> predicate)
        {
            return _olcuBrDal.Sil(predicate);
        }

        public bool Sil(List<MPOLCUBR> entity)
        {
            return _olcuBrDal.Sil(entity);
        }
    }
}
