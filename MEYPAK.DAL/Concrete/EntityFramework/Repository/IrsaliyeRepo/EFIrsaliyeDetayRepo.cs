using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public List<MPIRSALIYEDETAY> PagingList(int skip, int take)
        {
            return _context.MPIRSALIYEDETAY.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

     
    }
}
