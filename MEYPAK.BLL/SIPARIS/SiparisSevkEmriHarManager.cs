using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
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
    }
}
