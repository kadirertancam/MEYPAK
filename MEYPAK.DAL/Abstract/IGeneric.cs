using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract
{
    public interface IGeneric<T>
    { 
        List<T> Getir(Expression<Func<T, bool>> predicate);
        List<T> Listele();
        bool Sil(Expression<Func<T, bool>> predicate);
        bool Sil(List<T> entity);
        Durum Guncelle(T entity);  
        T Ekle(T entity);
    }
}
