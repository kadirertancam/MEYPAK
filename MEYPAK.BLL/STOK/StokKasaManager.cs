using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokKasaManager : BaseManager<PocoSTOKKASA,MPSTOKKASA>, IStokKasaServis
    {
        IStokKasaDal _kasaDal;
        IMapper _mapper;
        public StokKasaManager(IMapper mapper,IStokKasaDal stokKasaDal) : base(mapper,stokKasaDal)
        {
            _kasaDal = stokKasaDal;
            _mapper = mapper;
        }

        public PocoSTOKKASA EkleyadaGuncelle(PocoSTOKKASA pModel)
        {
            return _mapper.Map<MPSTOKKASA, PocoSTOKKASA>(_kasaDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKKASA, MPSTOKKASA>(pModel)));
        }
    }
    
}
