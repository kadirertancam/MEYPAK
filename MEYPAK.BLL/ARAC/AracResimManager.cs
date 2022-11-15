using AutoMapper;
using MEYPAK.DAL.Abstract;
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
    public class AracResimManager : BaseManager<PocoARACRESIM, MPARACRESIM>, IAracResimServis
    {
        IAracResimDal _aracResimServis;
        IMapper _mapper;
        public AracResimManager(IMapper mapper, IAracResimDal repo) : base(mapper, repo)
        {
            _aracResimServis = repo;
            _mapper = mapper;
        }

        public PocoARACRESIM EkleyadaGuncelle(PocoARACRESIM entity)
        {
            return _mapper.Map<MPARACRESIM, PocoARACRESIM>(_aracResimServis.EkleyadaGuncelle(_mapper.Map<PocoARACRESIM, MPARACRESIM>(entity)));
        }
    }
}
