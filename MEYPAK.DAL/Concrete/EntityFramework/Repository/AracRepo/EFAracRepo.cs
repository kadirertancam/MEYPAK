﻿using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.ARAC.Mobiliz;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFAracRepo : EFBaseRepo<MPARAC>, IAracDal
    {
        MEYPAKContext _context;
        public EFAracRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }


    }
}
