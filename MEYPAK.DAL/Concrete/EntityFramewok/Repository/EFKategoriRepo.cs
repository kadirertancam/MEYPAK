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
    public class EFKategoriRepo :EFBaseRepo<MPKATEGORI> ,IKategoriDal
    {

        MEYPAKContext context;
        public EFKategoriRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

        public Durum EkleyadaGuncelle(MPKATEGORI entity)
        {
            bool exists = context.MPKATEGORI.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPKATEGORI.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPKATEGORI temp = context.MPKATEGORI.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPKATEGORI.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

      
    }
}
