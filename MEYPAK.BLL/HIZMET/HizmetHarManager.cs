using AutoMapper;
using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.HIZMET
{
    public class HizmetHarManager : BaseManager<PocoHIZMETHAR, MPHIZMETHAR>, IHizmetHarServis
    {
        IHizmetHarDal _hizmetDal;
        IMapper _mapper;

        public HizmetHarManager(IMapper mapper, IHizmetHarDal hizmetDal) : base(mapper, hizmetDal)
        {
            _hizmetDal = hizmetDal;
            _mapper = mapper;
        }


        public PocoHIZMETHAR EkleyadaGuncelle(PocoHIZMETHAR pModel)
        {
            return _mapper.Map<MPHIZMETHAR, PocoHIZMETHAR>(_hizmetDal.EkleyadaGuncelle(_mapper.Map<PocoHIZMETHAR, MPHIZMETHAR>(pModel)));

        }
    }
}
