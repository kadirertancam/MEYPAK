using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoTransferHarManager : BaseManager<PocoDEPOTRANSFERHAR,MPDEPOTRANSFERHAR>, IDepoTransferHarServis
    {
        IDepoTransferHarDal _depoTransferHarDal;
        IMapper _mapper;
        public DepoTransferHarManager(IMapper mapper,IDepoTransferHarDal depoTransferHarDal) : base(mapper,depoTransferHarDal)
        {
            _depoTransferHarDal = depoTransferHarDal;
            _mapper = mapper;
        }

        public PocoDEPOTRANSFERHAR EkleyadaGuncelle(PocoDEPOTRANSFERHAR pModel)
        {
            return _mapper.Map<MPDEPOTRANSFERHAR,PocoDEPOTRANSFERHAR>(_depoTransferHarDal.EkleyadaGuncelle(_mapper.Map<PocoDEPOTRANSFERHAR,MPDEPOTRANSFERHAR>(pModel)));
        }
    }
}
