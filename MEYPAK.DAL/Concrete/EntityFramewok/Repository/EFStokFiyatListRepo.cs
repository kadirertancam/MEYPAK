using MEYPAK.DAL.Abstract.StokDal;
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
    public class EFStokFiyatListRepo : EFBaseRepo<MPSTOKFIYATLIST>,IStokFiyatListDal
    {
        MEYPAKContext context;
        public EFStokFiyatListRepo(MEYPAKContext _context) : base(_context)
        {
            context= _context;
        }
        public Durum EkleyadaGuncelle(MPSTOKFIYATLIST entity)
        {
            bool exists = context.MPSTOKFIYATLIST.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKFIYATLIST.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOKFIYATLIST temp = context.MPSTOKFIYATLIST.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKFIYATLIST.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
    }
}
