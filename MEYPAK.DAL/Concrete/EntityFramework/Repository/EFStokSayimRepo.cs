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
    public class EFStokSayimRepo : EFBaseRepo<MPSTOKSAYIM>, IStokSayimDal
    {
        MEYPAKContext _context;

        public EFStokSayimRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            //onYukle();
        }
        void onYukle()
        {
           
            var emp = _context.MPSTOKSAYIM.ToList();
            foreach (var item in emp)
            {
                _context.Entry(item)
                    .Collection(e =>  e.MPSTOKSAYIMHAR)
                    .Load();
               


            }
            EFStokSayimHarRepo rep = new EFStokSayimHarRepo(_context);
            rep.onYukle();

        }


        public MPSTOKSAYIM EkleyadaGuncelle(MPSTOKSAYIM entity)
        {

            bool exists = _context.MPSTOKSAYIM.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKSAYIM.Add(entity);
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
                _context.MPSTOKSAYIM.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOKSAYIM.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
        public IQueryable<MPSTOKSAYIM> Listee()
        {
            IQueryable<MPSTOKSAYIM> query = _context.MPSTOKSAYIM;


            //query = query.Include("MPSTOKHAR");
            //query = query.Include("MPSIPARISDETAY");
            //query = query.Include("MPSTOKSEVKİYATLİST");


            return query;
        }


    }
}
