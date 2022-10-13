using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatListHarRepo : EFBaseRepo<MPSTOKFIYATLISTHAR>, IStokFiyatListHarDal
    {
        MEYPAKContext _context;
        public EFStokFiyatListHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity)
        {
            bool exists = _context.MPSTOKFIYATLIST.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKFIYATLISTHAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                MPSTOKFIYATLISTHAR temp = _context.MPSTOKFIYATLISTHAR.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPSTOKFIYATLISTHAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
        public void Sil(int id)
        {
            MPSTOKFIYATLISTHAR deleteStok = _context.MPSTOKFIYATLISTHAR.Where(x => x.ID == id).FirstOrDefault();
            deleteStok.KAYITTIPI = 1;
            _context.MPSTOKFIYATLISTHAR.Update(deleteStok);
            _context.SaveChanges();
        }
    }
}
