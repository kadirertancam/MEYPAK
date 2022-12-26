using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces
{
    public interface IGenericServis<Poco>
    { 
        List<Poco> Getir(Expression<Func<Poco, bool>> expression);
        List<Poco> Listele();
        public bool DeleteById(int id);
        bool Sil(List<Poco> entity);
        Durum Guncelle(Poco entity, Expression<Func<Poco, bool>> predicate);
        Poco EkleyadaGuncelle(Poco entity);
        Durum Guncelle(Poco entity);
        Poco Ekle(Poco entity);
    }
}
