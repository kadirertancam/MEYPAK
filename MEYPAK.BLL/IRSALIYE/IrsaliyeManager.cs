using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using AutoMapper;

namespace MEYPAK.BLL.IRSALIYE
{
    public class IrsaliyeManager : BaseManager<PocoIRSALIYE,MPIRSALIYE>, IIrsaliyeServis
    {
        IIrsaliyeDal _irsaliyeDal;
        IMapper _mapper;

        public IrsaliyeManager(IMapper mapper,IIrsaliyeDal irsaliyeDal) : base(mapper,irsaliyeDal)
        {
            _irsaliyeDal = irsaliyeDal;
            _mapper = mapper;
        }



        public PocoIRSALIYE EkleyadaGuncelle(PocoIRSALIYE pModel)
        {
            return _mapper.Map<MPIRSALIYE,PocoIRSALIYE>( _irsaliyeDal.EkleyadaGuncelle(_mapper.Map<PocoIRSALIYE,MPIRSALIYE>(pModel)));
        }
    }
}
