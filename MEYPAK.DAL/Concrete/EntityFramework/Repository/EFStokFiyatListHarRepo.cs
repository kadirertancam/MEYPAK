using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System.Data.Entity;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatListHarRepo : EFBaseRepo<MPSTOKFIYATLISTHAR>, IStokFiyatListHarDal
    {
        MEYPAKContext _context;
        public EFStokFiyatListHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            
        }

        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity)
        {
            bool exists = _context.MPSTOKFIYATLISTHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKFIYATLISTHAR.Add(entity);
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
                _context.MPSTOKFIYATLISTHAR.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOKFIYATLISTHAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }


        public List<MPSTOKFIYATLISTHAR> PagingList(int skip, int take)
        {
            return _context.MPSTOKFIYATLISTHAR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }
    }
}
