using MEYPAK.DAL;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoManager : IDepoServis
    {
        IDepoDal _depoDal;

        public DepoManager(IDepoDal depoDal)
        {
            _depoDal = depoDal;
        }
        public Interfaces.Durum Ekle(MPDEPO entity)
        {
            return _depoDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPDEPO entity)
        {
            return _depoDal.EkleyadaGuncelle(entity);
        }
 
        public List<MPDEPO> Getir(Expression<Func<MPDEPO, bool>> expression)
        {
            return _depoDal.Getir(expression).ToList();
        }

        public Durum Guncelle(MPDEPO entity)
        {
            return _depoDal.Guncelle(entity);
        }

        public List<MPDEPO> Listele()
        {
            return _depoDal.Listele();
        }

        public bool Sil(Expression<Func<MPDEPO, bool>> predicate)
        {
            return _depoDal.Sil(predicate);
        }

        public bool Sil(List<MPDEPO> entity)
        {
            return _depoDal.Sil(entity);
        }
    }
}
