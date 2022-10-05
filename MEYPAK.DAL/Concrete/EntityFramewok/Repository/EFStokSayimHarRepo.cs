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

namespace MEYPAK.DAL.Concrete.EntityFramewok.Repository
{
    public class EFStokSayimHarRepo :EFBaseRepo<MPSTOKSAYIMHAR> ,IStokSayimHarDal
    {
        MEYPAKContext context ;

        public EFStokSayimHarRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

       
        public Durum EkleyadaGuncelle(MPSTOKSAYIMHAR entity)
        {
            bool exists = context.MPSTOKSAYIMHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKSAYIMHAR.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOKSAYIMHAR temp = context.MPSTOKSAYIMHAR.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKSAYIMHAR.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

       
    }
}
