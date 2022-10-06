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

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFOlcuBrRepo : EFBaseRepo<MPOLCUBR>, IOlcuBrDal
    {
        MEYPAKContext context;

        public EFOlcuBrRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }


        public Durum EkleyadaGuncelle(MPOLCUBR entity)
        {
            bool exists = context.MPOLCUBR.Any(x => x.ID == entity.ID);

            if (!exists)
            {
                context.MPOLCUBR.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPOLCUBR temp = context.MPOLCUBR.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPOLCUBR.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }

        }


    }
}
