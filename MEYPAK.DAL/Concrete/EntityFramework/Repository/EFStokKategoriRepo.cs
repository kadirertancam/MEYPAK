using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokKategoriRepo : EFBaseRepo<MPSTOKKATEGORI>, IStokKategoriDal
    {

        MEYPAKContext context;
        public EFStokKategoriRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

        public Durum EkleyadaGuncelle(MPSTOKKATEGORI entity)
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
                MPSTOKKATEGORI temp = context.MPKATEGORI.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPKATEGORI.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }


    }
}
