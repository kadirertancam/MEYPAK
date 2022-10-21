using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.ARAC.Mobiliz;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFAracRepo : EFBaseRepo<MPARACLAR>, IAracDal
    {
        MEYPAKContext _context;
        public EFAracRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public MPARACLAR EkleyadaGuncelle(MPARACLAR entity)
        {
            bool exists = _context.MPARACLAR.Any(x => x.ID == entity.ID);

            if (!exists)
            {
                _context.MPARACLAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPARACLAR.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPARACLAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
