﻿using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.PersonelRepo
{
    public class EFPersonelBelgeRepo : EFBaseRepo<MPPERSONELBELGE>,IPersonelBelgeDal
    {
        MEYPAKContext context;
        public EFPersonelBelgeRepo(MEYPAKContext _context) : base(_context)
        {
            context= _context;
        }
    }
}
