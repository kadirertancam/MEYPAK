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
    public class SatınAlmaMalKabulHarManager : BaseManager<PocoSATINALMAMALKABULEMRIHAR, MPSATINALMAMALKABULEMRIHAR>, ISatinAlmaMalKabulEmriHarServis
    {
        ISatinAlmaMalKabulEmriHarDal _satinAlmaMalKabulEmriHarDal;
        IMapper _mapper;
        public SatınAlmaMalKabulHarManager(IMapper mapper, ISatinAlmaMalKabulEmriHarDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            _satinAlmaMalKabulEmriHarDal = repo;
            _mapper = mapper;
        }

        public List<PocoSATINALMAMALKABULEMRIHAR> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSATINALMAMALKABULEMRIHAR>>(_satinAlmaMalKabulEmriHarDal.PagingList(skip, take));
        }

        public PocoSATINALMAMALKABULEMRIHAR EkleyadaGuncelle(PocoSATINALMAMALKABULEMRIHAR entity)
        {
            return _mapper.Map<MPSATINALMAMALKABULEMRIHAR, PocoSATINALMAMALKABULEMRIHAR>(_satinAlmaMalKabulEmriHarDal.EkleyadaGuncelle(_mapper.Map<PocoSATINALMAMALKABULEMRIHAR, MPSATINALMAMALKABULEMRIHAR>(entity)));
        }
    }
}
