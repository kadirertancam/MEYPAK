using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokSayimRepo : EFBaseRepo<MPSTOKSAYIM>, IStokSayimDal
    {
        MEYPAKContext context;

        public EFStokSayimRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
            onYukle();
        }
        void onYukle()
        {

            var emp = context.MPSTOKSAYIM.ToList();
            foreach (var item in emp)
            {
                context.Entry(item)
                    .Collection(e => e.MPSTOKSAYIMHAR)
                    .Load();

            }
        }


        public Durum EkleyadaGuncelle(MPSTOKSAYIM entity)
        {

            bool exists = context.MPSTOKSAYIM.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKSAYIM.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOKSAYIM temp = context.MPSTOKSAYIM.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKSAYIM.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }


    }
}
