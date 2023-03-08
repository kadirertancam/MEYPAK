using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.EIslemlerDal;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Interfaces.EIslemler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.EISLEMLER
{
    public class GidenIrsaliyeManager : BaseManager<PocoGIDENIRSALIYELER, MPGIDENIRSALIYELER>,IGidenIrsaliyeServis
    {
        IGidenIrsaliyeDal gidenIrsaliyeDal;
        IMapper _mapper;

        public GidenIrsaliyeManager(IMapper mapper, IGidenIrsaliyeDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            gidenIrsaliyeDal = repo;
        }
    }
}
