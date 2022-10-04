using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramewok.Repository
{
    public class EFPersonelRepo : IPersonelDal
    {
        MEYPAKContext context = new MEYPAKContext();
        public Durum Ekle(MPPERSONEL entity)
        {
            context.MPPERSONEL.Add(entity);
            context.SaveChanges();
            return Durum.kayıtbaşarılı;
        }

        public Durum EkleyadaGuncelle(MPPERSONEL entity)
        {
            bool exists = context.MPPERSONEL.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPPERSONEL.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPPERSONEL temp = context.MPPERSONEL.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPPERSONEL.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public List<MPPERSONEL> Getir(string entity)
        {
            return context.MPPERSONEL.Where(x => x.ID.ToString() == entity).ToList();
        }

        public List<MPPERSONEL> Getir(Expression<Func<MPPERSONEL, bool>> predicate)
        {
             var a = context.MPPERSONEL.Where(predicate).ToList();
            return a;
        }

        public List<MPPERSONEL> Guncelle(MPPERSONEL entity)
        {
            context.MPPERSONEL.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPPERSONEL> Listele()
        {
            return context.MPPERSONEL.ToList();
        }

        public bool Sil(Expression<Func<MPPERSONEL, bool>> predicate)
        {
            return Sil(predicate);
        }

        public bool Sil(List<MPPERSONEL> entity)
        {
            foreach (var item in entity)
            {
                context.MPPERSONEL.Remove(item);
            }
            context.SaveChanges();
            return true;

        }
    }
}
