using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoTransferHarRepo : EFBaseRepo<MPDEPOTRANSFERHAR>, IDepoTransferHarDal
    {
        MEYPAKContext _context;
        public EFDepoTransferHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context; 
        }
        public MPDEPOTRANSFERHAR EkleyadaGuncelle(MPDEPOTRANSFERHAR entity)
        {
            bool exists = _context.MPDEPOTRANSFERHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPDEPOTRANSFERHAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPDEPOTRANSFERHAR.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPDEPOTRANSFERHAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }
        public void Sil(int id)
        {
            MPDEPOTRANSFERHAR deleteStokHar = _context.MPDEPOTRANSFERHAR.Where(x => x.ID == id).FirstOrDefault();
            deleteStokHar.KAYITTIPI = 1;
            _context.MPDEPOTRANSFERHAR.Update(deleteStokHar);
            _context.SaveChanges();
        }
    }
}
