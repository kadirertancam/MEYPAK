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
    public class AracKaskoResimManager : BaseManager<PocoARACKASKORESIM, MPARACKASKORESIM>, IAracKaskoResimServis
    {
        IAracKaskoResimDal _aracKaskoResimServis;
        IMapper _mapper;
        public AracKaskoResimManager(IMapper mapper, IAracKaskoResimDal repo) : base(mapper, repo)
        {
            _aracKaskoResimServis = repo;
            _mapper = mapper;
        }

        public PocoARACKASKORESIM EkleyadaGuncelle(PocoARACKASKORESIM entity)
        {
            return _mapper.Map<MPARACKASKORESIM, PocoARACKASKORESIM>(_aracKaskoResimServis.EkleyadaGuncelle(_mapper.Map<PocoARACKASKORESIM, MPARACKASKORESIM>(entity)));
        }
    }
}
