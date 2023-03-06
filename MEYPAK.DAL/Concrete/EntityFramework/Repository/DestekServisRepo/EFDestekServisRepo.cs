using MEYPAK.DAL.Abstract.DestekServisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DESTEKSERVİS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.DestekServisRepo
{
    public class EFDestekServisRepo : EFBaseRepo<MPDESTEKSERVİS> , IDestekServisDal
    {
        MEYPAKContext _context;
        public EFDestekServisRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }
    }
}
