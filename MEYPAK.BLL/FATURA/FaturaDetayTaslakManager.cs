using AutoMapper;
using MEYPAK.DAL.Abstract;
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
    public class FaturaDetayTaslakManager : BaseManager<PocoFATURADETAYTASLAK, MPFATURADETAYTASLAK>, IFaturaDetayTaslakServis
    {
        public FaturaDetayTaslakManager(IMapper mapper, IGeneric<MPFATURADETAYTASLAK> repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
