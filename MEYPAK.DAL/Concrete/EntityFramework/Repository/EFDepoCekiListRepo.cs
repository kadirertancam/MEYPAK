using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoCekiListRepo : EFBaseRepo<MPDEPOCEKILIST>,IDepoCekiListDal
    {
        MEYPAKContext _context;
        public EFDepoCekiListRepo(MEYPAKContext context) : base(context)
        {
            _context=context;
        }

        public List<MPDEPOCEKILIST> PagingList(int skip, int take)
        {
            return _context.MPDEPOCEKILIST.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

   
    }
}
