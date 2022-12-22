using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFPersonelRepo : EFBaseRepo<MPPERSONEL>, IPersonelDal
    {
        MEYPAKContext context;

        public EFPersonelRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

        public List<MPPERSONEL> PagingList(int skip, int take)
        {
            return context.MPPERSONEL.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

    


    }
}
