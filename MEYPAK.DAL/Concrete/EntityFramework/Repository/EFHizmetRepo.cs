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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                context.MPHIZMET.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.MPHIZMET.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }


    }
}
