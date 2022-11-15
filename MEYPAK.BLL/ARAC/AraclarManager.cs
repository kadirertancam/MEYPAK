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
    public class AraclarManager : BaseManager<PocoARACLAR, MPARACLAR>, IAraclarServis
    {
        IAraclarDal _aracDal;
        IMapper _mapper;

        public AraclarManager(IMapper mapper, IAraclarDal aracDal) : base(mapper, aracDal)
        {
            _aracDal = aracDal;
            _mapper = mapper;
        }

        public PocoARACLAR EkleyadaGuncelle(PocoARACLAR entity)
        {
            return _mapper.Map<MPARACLAR, PocoARACLAR>(_aracDal.EkleyadaGuncelle(_mapper.Map<PocoARACLAR, MPARACLAR>(entity)));
        }
    }
}
