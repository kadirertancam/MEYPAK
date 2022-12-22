using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.PersonelRepo
{
    public class EFPersonelZimmetRepo : EFBaseRepo<MPPERSONELZIMMET>, IPersonelZimmetDal
    {
        MEYPAKContext _context;
        public EFPersonelZimmetRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

     
    }
}
