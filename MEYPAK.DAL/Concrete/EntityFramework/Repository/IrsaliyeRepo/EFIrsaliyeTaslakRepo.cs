﻿using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.IRSALIYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.IrsaliyeRepo
{
    public class EFIrsaliyeTaslakRepo : EFBaseRepo<MPIRSALIYETASLAK>, IIrsaliyeTaslakDal
    {
        public EFIrsaliyeTaslakRepo(MEYPAKContext _context) : base(_context)
        {
        }
    }
}
