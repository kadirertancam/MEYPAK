﻿using MEYPAK.DAL.Abstract.EIslemlerDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.EISLEMLER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFGelenEFaturaStokEslemeRepo : EFBaseRepo<MPGELENFATURASTOKESLEME>, IGelenEFaturaStokEslemeDal
    {
        MEYPAKContext context;
        public EFGelenEFaturaStokEslemeRepo(MEYPAKContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}
