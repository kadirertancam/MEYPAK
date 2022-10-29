using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.IrsaliyeRepo
{
    public class EFIrsaliyeDetayRepo : EFBaseRepo<MPIRSALIYEDETAY>, IIrsaliyeDetayDal
    {
        MEYPAKContext _context;
        public EFIrsaliyeDetayRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public List<MPIRSALIYEDETAY> PagingList(int skip, int take)
        {
            return _context.MPIRSALIYEDETAY.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

        public MPIRSALIYEDETAY EkleyadaGuncelle(MPIRSALIYEDETAY entity)
        {
            bool exists = _context.MPIRSALIYEDETAY.Any(x => x.ID == entity.ID);

            if (!exists)
            {
                _context.MPIRSALIYEDETAY.Add(entity);
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
                _context.MPIRSALIYEDETAY.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPIRSALIYEDETAY.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
