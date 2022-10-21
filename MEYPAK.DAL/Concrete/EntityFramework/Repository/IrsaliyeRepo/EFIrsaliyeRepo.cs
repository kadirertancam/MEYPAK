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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPIRSALIYE.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPIRSALIYE.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
