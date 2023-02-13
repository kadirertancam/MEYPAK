using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.ParametreDal;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PARAMETRE
{
    public class KasaParamsManager : BaseManager<PocoKASAPARAMS, MPKASAPARAMS>,IKasaParamServis
    {
        IMapper mapper;
        IKasaParamsDal kasaParamsDal;
        public KasaParamsManager(IMapper mapper, IKasaParamsDal repo) : base(mapper, repo)
        {
            this.mapper=mapper;
            kasaParamsDal = repo; 
        }
    }
}
