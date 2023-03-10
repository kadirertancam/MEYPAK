using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.MustahsilDal;
using MEYPAK.Entity.Models.MUSTAHSIL;
using MEYPAK.Entity.PocoModels.MUSTAHSIL;
using MEYPAK.Interfaces.Mustahsil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.MUSTAHSIL
{
    public class MustahsilCariHarManager : BaseManager<PocoMUSTAHSILCARIHAR, MPMUSTAHSILCARIHAR>, IMustahsilCariHarServis
    {
        public MustahsilCariHarManager(IMapper mapper, IMustahsilCariHarDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
