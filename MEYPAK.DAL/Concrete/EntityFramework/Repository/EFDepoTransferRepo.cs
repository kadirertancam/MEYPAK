using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoTransferRepo : EFBaseRepo<MPDEPOTRANSFER>, IDepoTransferDal
    {
        MEYPAKContext _context;
        public EFDepoTransferRepo(MEYPAKContext context) : base(context)
        {
            _context=context;
        }

        public MPDEPOTRANSFER EkleyadaGuncelle(MPDEPOTRANSFER entity)
        {
            bool exists = _context.MPDEPOTRANSFER.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPDEPOTRANSFER.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                MPDEPOTRANSFER temp = _context.MPDEPOTRANSFER.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPDEPOTRANSFER.Update(entity);
                _context.SaveChanges();
                return _context.MPDEPOTRANSFER.Where(x => x.ID == temp.ID).FirstOrDefault(); 
            }
        }
    }
}
