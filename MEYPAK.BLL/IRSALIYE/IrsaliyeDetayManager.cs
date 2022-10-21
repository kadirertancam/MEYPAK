using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using AutoMapper;

namespace MEYPAK.BLL.IRSALIYE
{
    public class IrsaliyeDetayManager : BaseManager<PocoIRSALIYEDETAY,MPIRSALIYEDETAY>, IIrsaliyeDetayServis
    {
        IIrsaliyeDetayDal _irsaliyeDetayDal;
        IMapper _mapper;
        public IrsaliyeDetayManager(IMapper mapper ,IIrsaliyeDetayDal irsaliyeDetayDal) : base(mapper,irsaliyeDetayDal)
        {
            _irsaliyeDetayDal = irsaliyeDetayDal;
            _mapper = mapper;
        }



        public PocoIRSALIYEDETAY EkleyadaGuncelle(PocoIRSALIYEDETAY pModel)
        {
            return _mapper.Map<MPIRSALIYEDETAY,PocoIRSALIYEDETAY>( _irsaliyeDetayDal.EkleyadaGuncelle(_mapper.Map<PocoIRSALIYEDETAY,MPIRSALIYEDETAY>(pModel)));
        }
    }
}
