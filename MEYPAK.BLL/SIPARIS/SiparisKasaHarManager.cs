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
    public class SiparisKasaHarManager : BaseManager<PocoSIPARISKASAHAR, MPSIPARISKASAHAR>, ISiparisKasaHarServis
    {
        ISiparisKasaHarDal _siparisKasaHarDal;
        IMapper _mapper;
        public SiparisKasaHarManager(IMapper mapper, ISiparisKasaHarDal repo) : base(mapper, repo )
        {
            _mapper = mapper;
            _siparisKasaHarDal = repo;
        }

        public PocoSIPARISKASAHAR EkleyadaGuncelle(PocoSIPARISKASAHAR pModel)
        {

            return _mapper.Map<MPSIPARISKASAHAR, PocoSIPARISKASAHAR>(_siparisKasaHarDal.EkleyadaGuncelle(_mapper.Map<PocoSIPARISKASAHAR, MPSIPARISKASAHAR>(pModel)));
        }
    }
}
