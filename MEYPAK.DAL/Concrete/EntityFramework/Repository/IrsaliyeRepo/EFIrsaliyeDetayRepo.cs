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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPIRSALIYEDETAY.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPIRSALIYEDETAY.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
