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
    internal class GelenEFaturaStokEslemeManager : BaseManager<PocoGELENFATURASTOKESLEME, MPGELENFATURASTOKESLEME>, IGelenEFaturaStokEslemeServis
    {
        public GelenEFaturaStokEslemeManager(IMapper mapper, IGeneric<MPGELENFATURASTOKESLEME> repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
