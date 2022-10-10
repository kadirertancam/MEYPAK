using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisSevkEmriHarRepo : EFBaseRepo<MPSIPARISSEVKEMRIHAR>, ISiparisSevkEmriHarDal
    {
        MEYPAKContext context;
        public EFSiparisSevkEmriHarRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
