using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.IrsaliyeRepo
{
    public class EFIrsaliyeDetayRepo : EFBaseRepo<MPIRSALIYEDETAY>, IIrsaliyeDetayDal
    {
        MEYPAKContext _context;
        public EFIrsaliyeDetayRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public Durum EkleyadaGuncelle(MPIRSALIYEDETAY entity)
        {
            bool exists = _context.MPIRSALIYEDETAY.Any(x => x.ID == entity.ID);

            if (!exists)
            {
                _context.MPIRSALIYEDETAY.Add(entity);
                _context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPIRSALIYEDETAY temp = _context.MPIRSALIYEDETAY.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPIRSALIYEDETAY.Update(entity);
                _context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
    }
}
