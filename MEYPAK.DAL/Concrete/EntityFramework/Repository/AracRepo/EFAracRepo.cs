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
            bool exists = _context.MPARACLAR.Any(x => x.muId == entity.muId);

            if (!exists)
            {
                _context.MPARACLAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                //TODO
                //if (item.ESKIID == 0 || item.ESKIID == null)
                //{
                //    PropertyInfo propertyInfo3 = (item.GetType().GetProperty("ESKIID"));
                //    propertyInfo3.SetValue(item, Convert.ChangeType(item.ID, propertyInfo3.PropertyType), null);

                //}
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                PropertyInfo propertyInfo2 = (item.GetType().GetProperty("ID"));
                propertyInfo2.SetValue(item, Convert.ChangeType(0, propertyInfo2.PropertyType), null);
                _context.MPARACLAR.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPARACLAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
