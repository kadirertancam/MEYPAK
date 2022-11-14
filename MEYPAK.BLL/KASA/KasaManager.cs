using AutoMapper;
using MEYPAK.DAL.Abstract.KasaDal;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Interfaces.Kasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.KASA
{
    public class KasaManager:BaseManager<PocoKASA,MPKASA>,IKasaServis
    {
        IMapper _mapper;
        IKasaDal _kasaDal;
        public KasaManager(IMapper mapper, IKasaDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _kasaDal = repo;
        }

        public PocoKASA EkleyadaGuncelle(PocoKASA entity)
        {
            return _mapper.Map<MPKASA, PocoKASA>(_kasaDal.EkleyadaGuncelle(_mapper.Map<PocoKASA, MPKASA>(entity)));
        }
    }
}
