using MEYPAK.DAL.Abstract;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class BaseManager<T> : IGenericServis<T>
    {
        IGeneric<T> _generic;

        public BaseManager(IGeneric<T> generic)
        {
            this._generic = generic;

        }

        public T Ekle(T entity)
        {
            return _generic.Ekle(entity);
        } 

        public List<T> Getir(Expression<Func<T, bool>> predicate)
        {
            return _generic.Getir(predicate);
        }

        public Durum Guncelle(T entity)
        {
            return _generic.Guncelle(entity);
        }

        public List<T> Listele()
        {
            return _generic.Listele();
        }

        public bool Sil(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _generic.Sil(predicate);
        }

        public bool Sil(List<T> entity)
        {
            return _generic.Sil(entity);
        }

    }
}
