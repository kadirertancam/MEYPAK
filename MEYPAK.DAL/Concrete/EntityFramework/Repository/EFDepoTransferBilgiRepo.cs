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
    public class EFDepoTransferBilgiRepo : EFBaseRepo<MPDEPOTRANSFERBILGI>, IDepoTransferBilgiDal
    {
        MEYPAKContext _context;
        public EFDepoTransferBilgiRepo(MEYPAKContext context) : base(context)
        {
            _context = context; 
        }
        public MPDEPOTRANSFERBILGI EkleyadaGuncelle(MPDEPOTRANSFERBILGI entity)
        {
            bool exists = _context.MPDEPOTRANSFERBILGI.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPDEPOTRANSFERBILGI.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                MPDEPOTRANSFERBILGI temp = _context.MPDEPOTRANSFERBILGI.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPDEPOTRANSFERBILGI.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
