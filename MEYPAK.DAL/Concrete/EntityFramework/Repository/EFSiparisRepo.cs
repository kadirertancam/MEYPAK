using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisRepo : EFBaseRepo<MPSIPARIS>, ISiparisDal
    {
        MEYPAKContext context;
        public EFSiparisRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
            //onYukle();
        }
        void onYukle()
        {

            var emp = context.MPSIPARIS.ToList();
            foreach (var item in emp)
            {
                context.Entry(item)
                    .Collection(e => e.MPSIPARISDETAY)
                    .Load();
                context.Entry(item)
                    .Collection(e => e.MPDEPOEMIR)
                    .Load();
            }

        }
        public MPSIPARIS EkleyadaGuncelle(MPSIPARIS entity)
        {
            bool exists = context.MPSIPARIS.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSIPARIS.Add(entity);
                context.SaveChanges();
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
                context.MPSIPARIS.Add(item);
                context.SaveChanges();
                context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                context.MPSIPARIS.Update(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}
