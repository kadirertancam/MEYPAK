using AutoMapper;
using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.ARAC
{
    public class AracSigortaResimManager : BaseManager<PocoARACSIGORTARESIM, MPARACSIGORTARESIM>, IAracSigortaResimServis
    {
        IAracSigortaResimDal _aracSigortaResimServis;
        IMapper _mapper;
        public AracSigortaResimManager(IMapper mapper, IAracSigortaResimDal repo) : base(mapper, repo)
        {
            _aracSigortaResimServis = repo;
            _mapper = mapper;
        }

        public PocoARACSIGORTARESIM EkleyadaGuncelle(PocoARACSIGORTARESIM entity)
        {
            return _mapper.Map<MPARACSIGORTARESIM, PocoARACSIGORTARESIM>(_aracSigortaResimServis.EkleyadaGuncelle(_mapper.Map<PocoARACSIGORTARESIM, MPARACSIGORTARESIM>(entity)));
        }
    }
}
