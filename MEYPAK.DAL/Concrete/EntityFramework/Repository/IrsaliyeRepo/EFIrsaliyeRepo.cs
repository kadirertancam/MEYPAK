using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.IrsaliyeRepo
{
    public class EFIrsaliyeRepo : EFBaseRepo<MPIRSALIYE>, IIrsaliyeDal
    {
        MEYPAKContext _context;
        public EFIrsaliyeRepo(MEYPAKContext context) : base(context)
        {
            _context=context;
        }

        public Durum EkleyadaGuncelle(MPIRSALIYE entity)
        {
            bool exists = _context.MPIRSALIYE.Any(x => x.ID == entity.ID);

            if (!exists)
            {
                _context.MPIRSALIYE.Add(entity);
                _context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPIRSALIYE temp = _context.MPIRSALIYE.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPIRSALIYE.Update(entity);
                _context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
    }
}
