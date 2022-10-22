using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokMarkaRepo : EFBaseRepo<MPSTOKMARKA>, IStokMarkaDal
    {
        MEYPAKContext _context;

        public EFStokMarkaRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }



        public MPSTOKMARKA EkleyadaGuncelle(MPSTOKMARKA entity)
        {
            bool exists = _context.MPMARKA.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPMARKA.Add(entity);
                _context.SaveChanges();
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
                _context.MPMARKA.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                _context.MPMARKA.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }


    }
}
