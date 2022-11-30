using AutoMapper;
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
    public class SeriManager : BaseManager<PocoSERI, MPSERI>, ISeriServis
    {
        ISeriDal _seriDal;
        IMapper _mapper;
        public SeriManager(IMapper mapper, ISeriDal repo) : base(mapper, repo)
        {
            _seriDal = repo;
            _mapper = mapper;
        }
        public PocoSERI EkleyadaGuncelle(PocoSERI pModel)
        {
            return _mapper.Map<MPSERI, PocoSERI>(_seriDal.EkleyadaGuncelle(_mapper.Map<PocoSERI, MPSERI>(pModel)));
        }
    }
}
