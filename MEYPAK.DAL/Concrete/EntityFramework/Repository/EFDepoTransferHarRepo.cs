using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public List<MPDEPOTRANSFERHAR> PagingList(int skip, int take)
        {
            return _context.MPDEPOTRANSFERHAR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

       
     
    }
}
