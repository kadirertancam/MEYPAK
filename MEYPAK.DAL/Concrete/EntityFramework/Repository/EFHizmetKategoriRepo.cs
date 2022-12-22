using MEYPAK.DAL.Abstract.HizmetDal;
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
    public class EFHizmetKategoriRepo : EFBaseRepo<MPHIZMETKATEGORI>, IHizmetKategoriDal
    {
        MEYPAKContext _context;
        public EFHizmetKategoriRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

     
    }
}
