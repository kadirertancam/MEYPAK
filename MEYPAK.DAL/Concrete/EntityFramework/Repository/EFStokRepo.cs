using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{

    public class EFStokRepo : EFBaseRepo<MPSTOK>, IStokDal
    {
        MEYPAKContext _context;

        EFStokFiyatListRepo rr;
        EFStokFiyatListHarRepo ss;
        EFStokOlcuBrRepo yy;
        EFOlcuBrRepo aa;
        public EFStokRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        //    rr = new EFStokFiyatListRepo(_context);
        //    ss = new EFStokFiyatListHarRepo(_context);
       //     aa = new EFOlcuBrRepo(_context);
      //      onYukle();
        }
        public void onYukle()
        {

            var emp = _context.MPSTOK.ToList();

            //emp = emp.Include("MPSTOKOLCUBR");
            //emp = emp.Include("MPSTOKHAR");
            //emp = emp.Include("MPSTOKSAYIMHAR");
            //emp = emp.Include("MPSTOKFIYATLISTHAR");
            //emp = emp.Include("MPSIPARISDETAY");
            //emp = emp.Include("MPSTOKSEVKİYATLİST");
            //emp = emp.Include("MPSTOKMALKABULLIST");
            //emp.Include("MPSTOKFIYATLISTHAR").Load();

            foreach (var item in emp)
            {


                _context.Entry(item)
                    .Collection(e => e.MPSTOKOLCUBR)
                    .Load();
                _context.Entry(item)
                   .Collection(e => e.MPSIPARISDETAY)
                   .Load();
                _context.Entry(item)
                    .Collection(e => e.MPSTOKHAR)
                    .Load();
                _context.Entry(item)
                    .Collection(e => e.MPSTOKSAYIMHAR)
                    .Load();
                _context.Entry(item)
                    .Collection(e => e.MPSTOKFIYATLISTHAR)
                    .Load();

            }


        }
        public MPSTOK EkleyadaGuncelle(MPSTOK entity)
        {
           
            bool exists = _context.MPSTOK.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOK.Add(entity);
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
                _context.MPSTOK.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOK.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }

        public IQueryable<MPSTOK> Listee()
        {
            IQueryable<MPSTOK> query = _context.MPSTOK;


            //query = query.Include("MPSTOKHAR");
            //query = query.Include("MPSIPARISDETAY");
            ////query = query.Include("MPSTOKSEVKİYATLİST");

            //query.Include("MPSTOKHAR").Load();
            return query;
        }
    }
}
