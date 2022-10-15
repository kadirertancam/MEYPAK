using AutoMapper;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Hizmet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.HIZMET
{
    public class HizmetManager :BaseManager<PocoHIZMET,MPHIZMET>, IHizmetServis
    {
        IHizmetDal _hizmetDal;
        IMapper _mapper;

        public HizmetManager(IMapper mapper,IHizmetDal hizmetDal) : base(mapper,hizmetDal)
        {
            _hizmetDal = hizmetDal;
            _mapper = mapper;
        }


        public Durum EkleyadaGuncelle(PocoHIZMET pModel)
        {
            return _hizmetDal.EkleyadaGuncelle(_mapper.Map<PocoHIZMET,MPHIZMET>(pModel));
        }


    }
}
