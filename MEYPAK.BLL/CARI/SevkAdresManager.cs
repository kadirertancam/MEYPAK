using AutoMapper;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.CARI
{
    public class SevkAdresManager:BaseManager<PocoSEVKADRES,MPSEVKADRES>,ISevkAdresServis
    {
        IMapper _mapper;
        ISevkAdresDal _sevkAdresServis;

        public SevkAdresManager(IMapper mapper, ISevkAdresDal sevkAdresServis):base(mapper,sevkAdresServis)
        {
            _mapper = mapper;
            _sevkAdresServis = sevkAdresServis;
        }

        public PocoSEVKADRES EkleyadaGuncelle(PocoSEVKADRES entity)
        {
            return _mapper.Map<MPSEVKADRES, PocoSEVKADRES>(_sevkAdresServis.EkleyadaGuncelle(_mapper.Map<PocoSEVKADRES, MPSEVKADRES>(entity)));
        }
    }
}
