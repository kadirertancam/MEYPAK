using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatHarRepo : EFBaseRepo<MPSTOKFIYATHAR> , IStokFiyatHarDal
    {
        MEYPAKContext _context;
        public EFStokFiyatHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;

        }

   

        public List<MPSTOKFIYATHAR> PagingList(int skip, int take)
        {
            return _context.MPSTOKFIYATHAR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }
    }
}
