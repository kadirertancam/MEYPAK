using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public List<MPIRSALIYE> PagingList(int skip, int take)
        {
            return _context.MPIRSALIYE.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

      
    }
}
