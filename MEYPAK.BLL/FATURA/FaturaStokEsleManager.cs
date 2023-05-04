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
    public class FaturaStokEsleManager : BaseManager<PocoFATURASTOKESLE, MPFATURASTOKESLE>, IFaturaStokEsleServis
    {
        IFaturaStokEsleDal _faturaStokEsleDal;
        IMapper _mapper;

        public FaturaStokEsleManager(IMapper mapper, IFaturaStokEsleDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _faturaStokEsleDal = repo;

        }
    }
}
