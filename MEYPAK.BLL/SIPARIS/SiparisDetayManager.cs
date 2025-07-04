﻿using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Siparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.SIPARIS
{
    public class SiparisDetayManager : BaseManager<PocoSIPARISDETAY, MPSIPARISDETAY>, ISiparisDetayServis
    {
        ISiparisDetayDal _siparisDetayDal;
        IMapper _mapper;
        public SiparisDetayManager(IMapper mapper, ISiparisDetayDal siparisDetayDal) : base(mapper, siparisDetayDal)
        {
            _siparisDetayDal = siparisDetayDal;
            _mapper = mapper;
        }

        public List<PocoSIPARISDETAY> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSIPARISDETAY>>(_siparisDetayDal.PagingList(skip, take));
        }

        public PocoSIPARISDETAY EkleyadaGuncelle(PocoSIPARISDETAY pModel)
        {

            return _mapper.Map<MPSIPARISDETAY,PocoSIPARISDETAY>(_siparisDetayDal.EkleyadaGuncelle(_mapper.Map<PocoSIPARISDETAY, MPSIPARISDETAY>(pModel)));
        }
    }
}
