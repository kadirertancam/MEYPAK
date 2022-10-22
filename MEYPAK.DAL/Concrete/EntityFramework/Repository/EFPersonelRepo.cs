using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFPersonelRepo : EFBaseRepo<MPPERSONEL>, IPersonelDal
    {
        MEYPAKContext context;

        public EFPersonelRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }



        public MPPERSONEL EkleyadaGuncelle(MPPERSONEL entity)
        {
            bool exists = context.MPPERSONEL.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPPERSONEL.Add(entity);
                context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                if (item.ESKIID == 0 || item.ESKIID == null)
                {
                    PropertyInfo propertyInfo3 = (item.GetType().GetProperty("ESKIID"));
                    propertyInfo3.SetValue(item, Convert.ChangeType(item.ID, propertyInfo3.PropertyType), null);

                }
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                PropertyInfo propertyInfo2 = (item.GetType().GetProperty("ID"));
                propertyInfo2.SetValue(item, Convert.ChangeType(0, propertyInfo2.PropertyType), null);
                context.MPPERSONEL.Add(item);
                context.SaveChanges();
                context.ChangeTracker.Clear();
                context.MPPERSONEL.Update(entity);
                context.SaveChanges();
                return entity;
            }
        }


    }
}
