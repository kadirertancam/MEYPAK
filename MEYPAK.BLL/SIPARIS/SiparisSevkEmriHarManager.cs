using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Siparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.SIPARIS
{
    public class SiparisSevkEmriHarManager:BaseManager<PocoSIPARISSEVKEMIRHAR,MPSIPARISSEVKEMRIHAR>,ISiparisSevkEmriHarServis
    {
        ISiparisSevkEmriHarDal _siparisSevkEmriHarDal;
        IMapper _mapper;

        public SiparisSevkEmriHarManager(IMapper mapper,ISiparisSevkEmriHarDal siparisSevkEmriHarDal) : base(mapper,siparisSevkEmriHarDal)
        {
            _siparisSevkEmriHarDal = siparisSevkEmriHarDal;
            _mapper = mapper;
        }

        public PocoSIPARISSEVKEMIRHAR EkleyadaGuncelle(PocoSIPARISSEVKEMIRHAR pModel)
        {
            return _mapper.Map<MPSIPARISSEVKEMRIHAR, PocoSIPARISSEVKEMIRHAR>(_siparisSevkEmriHarDal.EkleyadaGuncelle(_mapper.Map<PocoSIPARISSEVKEMIRHAR, MPSIPARISSEVKEMRIHAR>(pModel)));
        }
    }
}
