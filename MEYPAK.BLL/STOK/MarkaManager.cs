using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class MarkaManager : IMarkaServis
    {
        IMarkaDal _markaDal;
        
        public MarkaManager(IMarkaDal markaDal)
        {
            this._markaDal = markaDal;
        }

        public Interfaces.Durum Ekle(MPMARKA entity)
        {
            return _markaDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPMARKA entity)
        {
            return _markaDal.EkleyadaGuncelle(entity);
        }

        public List<MPMARKA> Getir(string entity)
        {
            return _markaDal.Getir(entity);
        }

        public List<MPMARKA> Getir(Expression<Func<MPMARKA, bool>> expression)
        {
            return _markaDal.Getir(expression).ToList();
        }

        public List<MPMARKA> Guncelle(MPMARKA entity)
        {
            return _markaDal.Guncelle(entity); 
        }

        public List<MPMARKA> Listele()
        {
            return _markaDal.Listele(); 
        }

        public bool Sil(Expression<Func<MPMARKA, bool>> predicate)
        {
            return _markaDal.Sil(predicate);    
        }

        public bool Sil(List<MPMARKA> entity)
        {
            return _markaDal.Sil(entity);
        }
    }
}
