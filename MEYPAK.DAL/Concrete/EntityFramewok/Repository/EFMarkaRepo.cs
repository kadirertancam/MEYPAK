using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFMarkaRepo : IMarkaDal
    {
        MEYPAKContext context = new MEYPAKContext(); 
        public Interfaces.Durum Ekle(MPMARKA entity)
        {
            context.MPMARKA.Add(entity);
            context.SaveChanges();
            return Interfaces.Durum.başarılı;
        }

        public Durum EkleyadaGuncelle(MPMARKA entity)
        {
            bool exists = context.MPMARKA.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPMARKA.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPMARKA temp = context.MPMARKA.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPMARKA.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public List<MPMARKA> Getir(string entity)
        {
           return context.MPMARKA.Where(x=>x.ID.ToString()==entity).ToList();
        }

        public List<MPMARKA> Getir(Expression<Func<MPMARKA, bool>> predicate)
        {
            return context.MPMARKA.Where(predicate).ToList();   
        }

        public List<MPMARKA> Guncelle(MPMARKA entity)
        {
            context.MPMARKA.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPMARKA> Listele()
        {
            return context.MPMARKA.ToList();
        }

        public bool Sil(Expression<Func<MPMARKA, bool>> predicate)
        {
            return Sil(context.MPMARKA.Where(predicate).ToList());
        }

        public bool Sil(List<MPMARKA> entity)
        {
            foreach (var item in entity)
            {
                context.MPMARKA.Remove(item);
            }
            context.SaveChanges();
            return true;
        }
    }
}
