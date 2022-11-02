using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.ParametreDal;
using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Parametre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PARAMETRE
{
    public class ParaBirimManager : BaseManager<PocoPARABIRIM, MPPARABIRIM>, IParaBirimServis
    {
        IParaBirimDal _paraBirimDal;
        IMapper _mapper;
        public ParaBirimManager(IMapper mapper, IParaBirimDal repo) : base(mapper, repo)
        {
            _paraBirimDal = repo;
            _mapper = mapper;
        }
        public PocoPARABIRIM EkleyadaGuncelle(PocoPARABIRIM pModel)
        {
            return _mapper.Map<MPPARABIRIM, PocoPARABIRIM>(_paraBirimDal.EkleyadaGuncelle(_mapper.Map<PocoPARABIRIM, MPPARABIRIM>(pModel)));

        }
    }
}
