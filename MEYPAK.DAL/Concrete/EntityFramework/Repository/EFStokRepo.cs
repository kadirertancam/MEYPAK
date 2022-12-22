using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{

    public class EFStokRepo : EFBaseRepo<MPSTOK>, IStokDal
    {
        MEYPAKContext _context;

        //EFStokFiyatListRepo rr;
        //EFStokFiyatListHarRepo ss; 
        public EFStokRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
     
        }


        public List<MPSTOK> PagingList(int skip, int take )
        {
            var aa = _context.MPSTOK.Skip(skip).Take(take).OrderBy(x=>x.ID).ToList();
            return aa;

        }

       

     
    }
}
