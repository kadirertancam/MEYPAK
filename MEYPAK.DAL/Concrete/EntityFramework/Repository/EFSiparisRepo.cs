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

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisRepo : EFBaseRepo<MPSIPARIS>, ISiparisDal
    {
        MEYPAKContext context;
        public EFSiparisRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
            onYukle();
        }
        void onYukle()
        {

            var emp = context.MPSIPARIS.ToList();
            foreach (var item in emp)
            {
                context.Entry(item)
                    .Collection(e => e.MPSIPARISDETAY)
                    .Load();
            }

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
