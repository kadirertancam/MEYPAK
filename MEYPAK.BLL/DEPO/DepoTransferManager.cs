using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoTransferManager : BaseManager<PocoDEPOTRANSFER,MPDEPOTRANSFER>, IDepoTransferServis
    {
        IDepoTransferDal _depoTransferDal;
        IMapper _mapper;
        public DepoTransferManager(IMapper mapper,IDepoTransferDal depoTransferDal) : base(mapper,depoTransferDal)
        {
            _depoTransferDal = depoTransferDal;
            _mapper = mapper;
        }

        public PocoDEPOTRANSFER EkleyadaGuncelle(PocoDEPOTRANSFER pModel)
        {
            return _mapper.Map<MPDEPOTRANSFER,PocoDEPOTRANSFER>(_depoTransferDal.EkleyadaGuncelle(_mapper.Map<PocoDEPOTRANSFER,MPDEPOTRANSFER>(pModel)));
        }
        public List<PocoDepolarArasıTransfer> PocoDepolarArasıTransferListesi()
        {
            return _depoTransferDal.PocoDepolarArasıTransferListesi();
        }
    }
}
