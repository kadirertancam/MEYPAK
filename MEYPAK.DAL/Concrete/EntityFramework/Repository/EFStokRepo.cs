using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{

    public class EFStokRepo : EFBaseRepo<MPSTOK>, IStokDal
    {
        MEYPAKContext _context;

        EFStokFiyatListRepo rr;
        EFStokFiyatListHarRepo ss;
        EFStokOlcuBrRepo yy;
        EFOlcuBrRepo hh;
        public EFStokRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            rr = new EFStokFiyatListRepo(_context);
            ss = new EFStokFiyatListHarRepo(_context);
            yy= new EFStokOlcuBrRepo(_context);
            hh = new EFOlcuBrRepo(_context);
            onYukle();
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
                MPSTOK temp = _context.MPSTOK.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
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
