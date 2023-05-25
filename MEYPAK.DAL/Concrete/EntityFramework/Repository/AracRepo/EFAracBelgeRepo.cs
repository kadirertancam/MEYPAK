using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFAracBelgeRepo : EFBaseRepo<MPARACBELGE>, IAracBelgeDal
    {
        public EFAracBelgeRepo(MEYPAKContext _context) : base(_context)
        {
        }
    }
}
