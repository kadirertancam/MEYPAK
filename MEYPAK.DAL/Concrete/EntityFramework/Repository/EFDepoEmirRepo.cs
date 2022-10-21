using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoEmirRepo : EFBaseRepo<MPDEPOEMIR>,IDepoEmirDal
    {
        MEYPAKContext _context;
        public EFDepoEmirRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }
        public MPDEPOEMIR EkleyadaGuncelle(MPDEPOEMIR entity)
        {
            bool exists = _context.MPDEPOEMIR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPDEPOEMIR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPDEPOEMIR.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPDEPOEMIR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
