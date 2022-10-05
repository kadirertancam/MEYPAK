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
    public class EFSiparisDetayRepo : EFBaseRepo<MPSIPARISDETAY>, ISiparisDetayDal
    {
        MEYPAKContext context;
        public EFSiparisDetayRepo(MEYPAKContext _context) : base(_context)
        {
            this.context = _context;
        }

        public Durum EkleyadaGuncelle(MPSIPARISDETAY entity)
        {
            bool exists = context.MPSIPARISDETAY.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSIPARISDETAY.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSIPARISDETAY temp = context.MPSIPARISDETAY.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSIPARISDETAY.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
    }
}
