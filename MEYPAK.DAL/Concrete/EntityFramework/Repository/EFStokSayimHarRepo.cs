using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokSayimHarRepo : EFBaseRepo<MPSTOKSAYIMHAR>, IStokSayimHarDal
    {
        MEYPAKContext _context;

        public EFStokSayimHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
           

        }
        public List<MPSTOKSAYIMHAR> PagingList(int skip, int take)
        {
            return _context.MPSTOKSAYIMHAR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

       


    

    }
}
