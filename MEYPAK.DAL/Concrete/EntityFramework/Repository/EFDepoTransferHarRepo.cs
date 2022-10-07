using MEYPAK.DAL.Abstract.DepoDal;
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
    public class EFDepoTransferHarRepo : EFBaseRepo<MPDEPOTRANSFERHAR>, IDepoTransferHarDal
    {
        MEYPAKContext _context;
        public EFDepoTransferHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context; 
        }
        public MPDEPOTRANSFERHAR EkleyadaGuncelle(MPDEPOTRANSFERHAR entity)
        {
            bool exists = _context.MPDEPOTRANSFERHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPDEPOTRANSFERHAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                MPDEPOTRANSFERHAR temp = _context.MPDEPOTRANSFERHAR.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPDEPOTRANSFERHAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
        public void Sil(int id)
        {
            MPDEPOTRANSFERHAR deleteStokHar = _context.MPDEPOTRANSFERHAR.Where(x => x.ID == id).FirstOrDefault();
            deleteStokHar.KAYITTIPI = 1;
            _context.MPDEPOTRANSFERHAR.Update(deleteStokHar);
        }
    }
}
