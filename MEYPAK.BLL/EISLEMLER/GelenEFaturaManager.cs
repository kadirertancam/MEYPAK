using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.EIslemlerDal;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Interfaces.EIslemler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.EISLEMLER
{
    public class GelenEFaturaManager : BaseManager<PocoGELENEFATURA, MPGELENEFATURA>, IGelenFaturaServis
    {
        IGelenEFaturaDal _gelenEFaturaDal;
        IMapper mapper;
        public GelenEFaturaManager(IMapper mapper, IGelenEFaturaDal repo ) : base(mapper, repo )
        {
            _gelenEFaturaDal = repo;
            this.mapper = mapper;
        }

        
    }
}
