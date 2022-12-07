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
    public class SeriHarManager : BaseManager<PocoSERIHAR, MPSERIHAR>, ISeriHarServis
    {
        IMapper _mapper;
        ISeriHarDal _seriHarDal;
        public SeriHarManager(IMapper mapper, ISeriHarDal repo ) : base(mapper, repo )
        {
            _mapper = mapper;
            _seriHarDal=repo;
        }
        public PocoSERIHAR EkleyadaGuncelle(PocoSERIHAR pModel)
        {
            return _mapper.Map<MPSERIHAR, PocoSERIHAR>(_seriHarDal.EkleyadaGuncelle(_mapper.Map<PocoSERIHAR, MPSERIHAR>(pModel)));
        }
    }
}
