using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramewok.Repository
{
    public class EFSiparisRepo : EFBaseRepo<MPSIPARIS>, ISiparisDal
    {
        MEYPAKContext context;
        public EFSiparisRepo(MEYPAKContext _context) : base(_context)
        {
            this.context = _context;
        }
        
        public Durum EkleyadaGuncelle(MPSIPARIS entity)
        {
            bool exists = context.MPSIPARIS.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSIPARIS.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSIPARIS temp = context.MPSIPARIS.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSIPARIS.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
    }
}
