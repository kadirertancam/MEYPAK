using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
 
    public class EFStokRepo : EFBaseRepo<MPSTOK>,IStokDal
    {
        MEYPAKContext _context;

        public EFStokRepo(MEYPAKContext context) : base(context)
        {
            this._context = context;
        }
        public Durum EkleyadaGuncelle(MPSTOK entity)
        {
            bool exists = _context.MPSTOK.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOK.Add(entity);
                _context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOK temp = _context.MPSTOK.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPSTOK.Update(entity);
                _context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
    }
}
