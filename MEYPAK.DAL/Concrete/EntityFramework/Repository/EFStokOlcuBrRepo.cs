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
            onYukle();
        }

        void onYukle()
        {
          
            var emp = context.MPSTOKOLCUBR.ToList();
            EFOlcuBrRepo ff = new EFOlcuBrRepo(context);
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPSTOKOLCUBR.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSTOKOLCUBR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }

    }
}
