using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
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
    public class EFOlcuBrRepo : EFBaseRepo<MPOLCUBR>, IOlcuBrDal
    {
        MEYPAKContext context;

        public EFOlcuBrRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
           
        }
       public  void onYukle()
        { 

            var emp = context.MPOLCUBR.ToList();
            EFStokOlcuBrRepo aa= new EFStokOlcuBrRepo(context);
            foreach (var item in emp)
            {
                context.Entry(item)
                    .Collection(x=>x.MPSTOKSAYIMHAR)
                    .Load();
                context.Entry(item)
                   .Collection(x => x.MPSTOKOLCUBR)
                   .Load();
                context.Entry(item)
                    .Collection(x => x.MPSTOKSEVKİYATLİST)
                    .Load();
            }

        }

        public MPOLCUBR EkleyadaGuncelle(MPOLCUBR entity)
        {
            bool exists = context.MPOLCUBR.Any(x => x.ID == entity.ID);

            if (!exists)
            {
                context.MPOLCUBR.Add(entity);
                context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                if (item.ESKIID == 0 || item.ESKIID == null)
                {
                    PropertyInfo propertyInfo2 = (item.GetType().GetProperty("ESKIID"));
                    propertyInfo2.SetValue(item, Convert.ChangeType(item.ID, propertyInfo2.PropertyType), null);
                }
                PropertyInfo propertyInfo = (item.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(item, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("ID"));
                propertyInfo.SetValue(item, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.MPOLCUBR.Add(item);
                context.SaveChanges();
                context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                context.MPOLCUBR.Update(entity);
                context.SaveChanges();
                return entity;
            }

        }


    }
}
