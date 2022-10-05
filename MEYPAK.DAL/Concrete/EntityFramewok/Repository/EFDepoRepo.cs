using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
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
    public class EFDepoRepo : EFBaseRepo<MPDEPO>, IDepoDal
    {
        MEYPAKContext context;

        public EFDepoRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

        public Durum EkleyadaGuncelle(MPDEPO entity)
        {
            bool exists = context.MPDEPO.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPDEPO.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPDEPO temp = context.MPDEPO.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPDEPO.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

      
    }
}
