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
            onYukle();
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                context.MPOLCUBR.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.MPOLCUBR.Add(entity);
                context.SaveChanges();
                return entity;
            }

        }


    }
}
