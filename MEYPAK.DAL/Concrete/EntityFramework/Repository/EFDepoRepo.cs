using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoRepo : EFBaseRepo<MPDEPO>, IDepoDal
    {
        MEYPAKContext _context;

        public EFDepoRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public MPDEPO EkleyadaGuncelle(MPDEPO entity)
        {
            bool exists = _context.MPDEPO.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPDEPO.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPDEPO.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPDEPO.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }


    }
}
