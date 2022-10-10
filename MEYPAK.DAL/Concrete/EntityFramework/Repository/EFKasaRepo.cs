using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFKasaRepo : EFBaseRepo<MPKASA>, IKasaDal
    {
        public EFKasaRepo(MEYPAKContext context) : base(context)
        {
        }
    }
}
