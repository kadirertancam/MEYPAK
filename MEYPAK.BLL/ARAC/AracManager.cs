﻿using AutoMapper;
using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Abstract.DepoDal;
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
    public class AracManager:BaseManager<PocoARAC,MPARAC>,IAracServis
    {
        IAracDal _aracDal;
        IMapper _mapper;

        public AracManager(IMapper mapper, IAracDal aracDal) : base(mapper, aracDal)
        {
            _aracDal = aracDal;
            _mapper = mapper;
        }

        public PocoARAC EkleyadaGuncelle(PocoARAC entity)
        {
            return _mapper.Map<MPARAC, PocoARAC>(_aracDal.EkleyadaGuncelle(_mapper.Map<PocoARAC,MPARAC>(entity)));
        }
    }
}
