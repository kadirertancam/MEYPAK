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
    public class AracRotaManager : BaseManager<PocoARACROTA, MPARACROTA>, IAracRotaServis
    {
        IMapper _mapper;
        IAracRotaDal _aracRotaDal;
        public AracRotaManager(IMapper mapper, IAracRotaDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _aracRotaDal = repo;
        }

        public PocoARACROTA EkleyadaGuncelle(PocoARACROTA entity)
        {
            return _mapper.Map<MPARACROTA, PocoARACROTA>(_aracRotaDal.EkleyadaGuncelle(_mapper.Map<PocoARACROTA, MPARACROTA>(entity)));
        }
    }
}
