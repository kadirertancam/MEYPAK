using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFHizmetRepo : EFBaseRepo<MPHIZMET>, IHizmetDal
    {
        MEYPAKContext context;

        public EFHizmetRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }


        public MPHIZMET EkleyadaGuncelle(MPHIZMET entity)
        {
            bool exists = context.MPHIZMET.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPHIZMET.Add(entity);
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(item, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("ID"));
                propertyInfo.SetValue(item, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.MPHIZMET.Add(item);
                context.SaveChanges();
                context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                context.MPHIZMET.Update(entity);
                context.SaveChanges();
                return entity;
            }
        }


    }
}
