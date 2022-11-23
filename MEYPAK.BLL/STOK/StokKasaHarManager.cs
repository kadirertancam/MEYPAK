using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Abstract.KasaDal;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Kasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokKasaHarManager : BaseManager<PocoSTOKKASAHAR, MPSTOKKASAHAR>, IStokKasaHarServis
    {
        IMapper _mapper;
        IStokKasaHarDal _kasaHarDal;
        public StokKasaHarManager(IMapper mapper, IStokKasaHarDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _kasaHarDal = repo;
        }

        public PocoSTOKKASAHAR EkleyadaGuncelle(PocoSTOKKASAHAR entity)
        {
            return _mapper.Map<MPSTOKKASAHAR, PocoSTOKKASAHAR>(_kasaHarDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKKASAHAR, MPSTOKKASAHAR>(entity)));
        }
    }
}
