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
            onYukle();
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                context.MPSIPARIS.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.MPSIPARIS.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}
