using MEYPAK.DAL.Abstract.PersonelDal;
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
    public class EFPersonelRepo : EFBaseRepo<MPPERSONEL>, IPersonelDal
    {
        MEYPAKContext context;

        public EFPersonelRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }



        public Durum EkleyadaGuncelle(MPPERSONEL entity)
        {
            bool exists = context.MPPERSONEL.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPPERSONEL.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPPERSONEL temp = context.MPPERSONEL.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPPERSONEL.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }


    }
}
