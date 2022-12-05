using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFAraclarRepo :  IAraclarDal
    {
        MEYPAKContext _context;
        public EFAraclarRepo(MEYPAKContext context) 
        {
            _context = context;
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public MPARACLAR Ekle(MPARACLAR entity)
        {
            throw new NotImplementedException();
        }

        public MPARACLAR EkleyadaGuncelle(MPARACLAR entity)
        {
            bool exists = _context.MPARACLAR.Any(x => x.muId == entity.muId);

            if (!exists)
            {
                _context.MPARACLAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                //TODO
                //if (item.ESKIID == 0 || item.ESKIID == null)
                //{
                //    PropertyInfo propertyInfo3 = (item.GetType().GetProperty("ESKIID"));
                //    propertyInfo3.SetValue(item, Convert.ChangeType(item.ID, propertyInfo3.PropertyType), null);

                //}
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                PropertyInfo propertyInfo2 = (item.GetType().GetProperty("ID"));
                propertyInfo2.SetValue(item, Convert.ChangeType(0, propertyInfo2.PropertyType), null);
                _context.MPARACLAR.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPARACLAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }

        public List<MPARACLAR> Getir(Expression<Func<MPARACLAR, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Durum Guncelle(MPARACLAR entity, Expression<Func<MPARACLAR, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MPARACLAR Guncelle(MPARACLAR entity)
        {
            throw new NotImplementedException();
        }

        public List<MPARACLAR> Listele()
        {
            throw new NotImplementedException();
        }

        public bool Sil(List<MPARACLAR> entity)
        {
            throw new NotImplementedException();
        }
    }
}
