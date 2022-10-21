using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Siparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.SIPARIS
{
    public class SiparisManager : BaseManager<PocoSIPARIS, MPSIPARIS>, ISiparisServis
    {
        ISiparisDal _siparisDal;
        IMapper _mapper;
        public SiparisManager(IMapper mapper, ISiparisDal siparisDal) : base(mapper, siparisDal)
        {
            _siparisDal = siparisDal;
            _mapper = mapper;
        }

        public PocoSIPARIS EkleyadaGuncelle(PocoSIPARIS pModel)
        {

            return _mapper.Map<MPSIPARIS,PocoSIPARIS>( _siparisDal.EkleyadaGuncelle(_mapper.Map<PocoSIPARIS, MPSIPARIS>(pModel)));
        }
    }
}
