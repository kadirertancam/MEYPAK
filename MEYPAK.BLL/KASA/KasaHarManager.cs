using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Abstract.KasaDal;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Interfaces.Kasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.KASA
{
    public class KasaHarManager : BaseManager<PocoKASAHAR, MPKASAHAR>, IKasaHarServis
    {
        IMapper _mapper;
        IKasaHarDal _kasaHarDal;
        public KasaHarManager(IMapper mapper, IKasaHarDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _kasaHarDal = repo;
        }

        public PocoKASAHAR EkleyadaGuncelle(PocoKASAHAR entity)
        {
            return _mapper.Map<MPKASAHAR, PocoKASAHAR>(_kasaHarDal.EkleyadaGuncelle(_mapper.Map<PocoKASAHAR, MPKASAHAR>(entity)));
        }
    }
}
