using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.FaturaDal;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Interfaces.Fatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.FATURA
{
    public class FaturaTaslakManager : BaseManager<PocoFATURATASLAK, MPFATURATASLAK>, IFaturaTaslakServis
    {
        IFaturaTaslakDal _faturaDal;
        IMapper _mapper;
        public FaturaTaslakManager(IMapper mapper, IFaturaTaslakDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            _faturaDal=repo;
            _mapper=mapper;
        }
    }
}
