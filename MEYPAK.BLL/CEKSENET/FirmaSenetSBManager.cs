using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.CekSenetDal;
using MEYPAK.Entity.Models.CEKSENET;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.CekSenet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.CEKSENET
{
    public class FirmaSenetSBManager : BaseManager<PocoFIRMASENETSB, MPFIRMASENETSB>, IFirmaSenetSBServis
    {
        public FirmaSenetSBManager(IMapper mapper, IFirmaSenetSBDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
