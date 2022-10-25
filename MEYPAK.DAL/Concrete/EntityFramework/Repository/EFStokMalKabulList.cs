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
    public class EFStokMalKabulList : EFBaseRepo<MPSTOKMALKABULLIST>,IStokMalKKabulListDal
    {
        MEYPAKContext _context;
        public EFStokMalKabulList(MEYPAKContext context) : base(context)
        {
            _context = context;
            //OnYukle();
        }
        public MPSTOKMALKABULLIST EkleyadaGuncelle(MPSTOKMALKABULLIST entity)
        {
            OnYukle();
            bool exists = _context.MPSTOKMALKABULLIST.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKMALKABULLIST.Add(entity);
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(item, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("ID"));
                propertyInfo.SetValue(item, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSTOKMALKABULLIST.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOKMALKABULLIST.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }

        public void OnYukle()
        {
            var emp = _context.MPSTOKSEVKİYATLİST.ToList();
            foreach (var item in emp)
            {
                _context.Entry(item)
                  .Navigation("MPOLCUBR").Load();
                _context.Entry(item)
                  .Navigation("MPSTOK").Load();
                _context.Entry(item)
                  .Navigation("MPSIPARISDETAY").Load();


            }
        }
    }
}
