using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.IrsaliyeRepo
{
    public class EFIrsaliyeRepo : EFBaseRepo<MPIRSALIYE>, IIrsaliyeDal
    {
        MEYPAKContext _context;
        public EFIrsaliyeRepo(MEYPAKContext context) : base(context)
        {
            _context=context;
        }

        public MPIRSALIYE EkleyadaGuncelle(MPIRSALIYE entity)
        {
            bool exists = _context.MPIRSALIYE.Any(x => x.ID == entity.ID);

            if (!exists)
            {
                _context.MPIRSALIYE.Add(entity);
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
                _context.MPIRSALIYE.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                _context.MPIRSALIYE.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
