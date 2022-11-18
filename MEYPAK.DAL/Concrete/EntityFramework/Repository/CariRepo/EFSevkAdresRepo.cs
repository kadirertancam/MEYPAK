using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.CariRepo
{
    public class EFSevkAdresRepo : EFBaseRepo<MPSEVKADRES>, ISevkAdresDal
    {
        MEYPAKContext _context;
        public EFSevkAdresRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public MPSEVKADRES EkleyadaGuncelle(MPSEVKADRES entity)
        {
            bool exists = _context.MPSEVKADRES.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSEVKADRES.Add(entity);
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(item, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("ID"));
                propertyInfo.SetValue(item, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSEVKADRES.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSEVKADRES.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
