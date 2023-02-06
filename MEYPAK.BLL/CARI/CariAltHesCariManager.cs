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
    public class CariAltHesCariManager : BaseManager<PocoCARIALTHESCARI, MPCARIALTHESCARI>, ICariAltHesCariServis
    {
        ICariAltHesCariDal _cariAltHesCariDal;
        IMapper _mapper;
        public CariAltHesCariManager(IMapper mapper, ICariAltHesCariDal repo ) : base(mapper, repo)
        {
            _cariAltHesCariDal = repo;
            _mapper = mapper;
        }
        public PocoCARIALTHESCARI EkleyadaGuncelle(PocoCARIALTHESCARI entity)
        {
            return _mapper.Map<MPCARIALTHESCARI, PocoCARIALTHESCARI>(_cariAltHesCariDal.EkleyadaGuncelle(_mapper.Map<PocoCARIALTHESCARI, MPCARIALTHESCARI>(entity))); 
        }
    }
}
