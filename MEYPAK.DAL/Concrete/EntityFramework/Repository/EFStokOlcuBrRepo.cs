using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokOlcuBrRepo : EFBaseRepo<MPSTOKOLCUBR>, IStokOlcuBrDal
    {
        MEYPAKContext _context;

        public EFStokOlcuBrRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            //onYukle();
        }

        void onYukle()
        {
          
            var emp = _context.MPSTOKOLCUBR.ToList(); 
            //emp = emp.Include("MPSTOK");
            //emp = emp.Include("MPOLCUBR");
            foreach (var item in emp)
            {
                _context.Entry(item)
                    .Navigation("MPSTOK")
                    .Load();
                _context.Entry(item)
                    .Navigation("MPOLCUBR")
                    .Load();


            }


        }
        public MPSTOKOLCUBR EkleyadaGuncelle(MPSTOKOLCUBR entity)
        {
            bool exists = _context.MPSTOKOLCUBR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKOLCUBR.Add(entity);
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
                _context.MPSTOKOLCUBR.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOKOLCUBR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }

    }
}
