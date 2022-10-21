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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                context.MPPERSONEL.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.MPPERSONEL.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }


    }
}
