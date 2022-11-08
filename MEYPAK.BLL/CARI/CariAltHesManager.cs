using AutoMapper;
using MEYPAK.DAL.Abstract;
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
    public class CariAltHesManager : BaseManager<PocoCARIALTHES, MPCARIALTHES>, ICariAltHesServis
    {
        IMapper _mapper;
        ICariAltHesDal _cariAltHesDal;

        public CariAltHesManager(IMapper mapper, ICariAltHesDal repo) : base(mapper, repo)
        {
            _cariAltHesDal = repo;
            _mapper = mapper;
        }

        public PocoCARIALTHES EkleyadaGuncelle(PocoCARIALTHES entity)
        {
            return _mapper.Map<MPCARIALTHES, PocoCARIALTHES>(_cariAltHesDal.EkleyadaGuncelle(_mapper.Map<PocoCARIALTHES, MPCARIALTHES>(entity)));

        }
    }
}
