using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisSevkEmriHarRepo : EFBaseRepo<MPSIPARISSEVKEMRIHAR>, ISiparisSevkEmriHarDal
    {
        MEYPAKContext _context;
        public EFSiparisSevkEmriHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            //OnYukle();
        }
        public void OnYukle()
        {
            var emp = _context.MPSIPARISSEVKEMRIHAR.ToList();
            foreach (var item in emp)
            {
                _context.Entry(item)
                  .Navigation("MPSIPARIS").Load();
                _context.Entry(item)
                  .Navigation("MPSIPARISDETAY").Load();
                _context.Entry(item)
                  .Navigation("MPDEPOEMIR").Load();


            }
        }


        public MPSIPARISSEVKEMRIHAR EkleyadaGuncelle(MPSIPARISSEVKEMRIHAR entity)
        {
            bool exists = _context.MPSIPARISSEVKEMRIHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSIPARISSEVKEMRIHAR.Add(entity);
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
                _context.MPSIPARISSEVKEMRIHAR.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                _context.MPSIPARISSEVKEMRIHAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
