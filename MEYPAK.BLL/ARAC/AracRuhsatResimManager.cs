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
    public class AracRuhsatResimManager : BaseManager<PocoARACRUHSATRESIM, MPARACRUHSATRESIM>, IAracRuhsatResimServis
    {
        IAracRuhsatResimDal _aracRuhsatResimServis;
        IMapper _mapper;
        public AracRuhsatResimManager(IMapper mapper, IAracRuhsatResimDal repo) : base(mapper, repo)
        {
            _aracRuhsatResimServis = repo;
            _mapper = mapper;
        }

        public PocoARACRUHSATRESIM EkleyadaGuncelle(PocoARACRUHSATRESIM entity)
        {
            return _mapper.Map<MPARACRUHSATRESIM, PocoARACRUHSATRESIM>(_aracRuhsatResimServis.EkleyadaGuncelle(_mapper.Map<PocoARACRUHSATRESIM, MPARACRUHSATRESIM>(entity)));
        }
    }
}
