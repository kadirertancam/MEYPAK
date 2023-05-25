using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Interfaces.IRSALIYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.IRSALIYE
{
    public class IrsaliyeDetayTaslakManager : BaseManager<PocoIRSALIYEDETAYTASLAK, MPIRSALIYEDETAYTASLAK>,IIrsaliyeDetayTaslakServis
    {
        public IrsaliyeDetayTaslakManager(IMapper mapper, IIrsaliyeDetayTaslakDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
