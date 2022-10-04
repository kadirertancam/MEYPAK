using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces
{
    public interface IGenericServis<T>
    {
        List<T> Getir(string entity);
        List<T> Getir(Expression<Func<T, bool>> expression);
        List<T> Listele();
        bool Sil(Expression<Func<T, bool>> predicate);
        bool Sil(List<T> entity);
        List<T> Guncelle(T entity);
        Interfaces.Durum EkleyadaGuncelle(T entity);

        Durum Ekle(T entity);
    }
}
