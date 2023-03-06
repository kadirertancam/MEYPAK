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
    public class GidenFaturalarManager : BaseManager<PocoGIDENFATURALAR, MPGIDENFATURALAR>, IGidenFaturalarServis
    {
        IMapper _mapper;
        IGidenFaturalarDal gidenFaturalarDal;
        public GidenFaturalarManager(IMapper mapper, IGidenFaturalarDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            gidenFaturalarDal = repo;
        }
    }
}
