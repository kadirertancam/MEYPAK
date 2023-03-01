using MEYPAK.DAL.Abstract.ParametreDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.PARAMETRE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.ParametreRepo
{
    public class EFEFaturaParamsRepo : EFBaseRepo<MPEFATURAPARAMS>, IEFaturaParamsDal
    {
        MEYPAKContext context;
        public EFEFaturaParamsRepo(MEYPAKContext _context) : base(_context)
        {
            context=_context;
        }
    }
}
