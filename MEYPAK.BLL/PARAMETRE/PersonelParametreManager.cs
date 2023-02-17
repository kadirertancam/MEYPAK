using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.ParametreDal;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Parametre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PARAMETRE
{
    public class PersonelParametreManager : BaseManager<PocoPERSONELPARAMETRE, MPPERSONELPARAMETRE>, IPersonelParametreServis
    {
        IPersonelParametreDal personelParamDal;
        IMapper _mapper;
        public PersonelParametreManager(IMapper mapper, IPersonelParametreDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            personelParamDal = repo;
            _mapper= mapper;
        }
    }
}
