using AutoMapper;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Abstract.DestekServisDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.DESTEKSERVİS;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.DESTEKSERVIS;
using MEYPAK.Interfaces.DestekServis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DESTEKSERVIS
{
    public class DestekServisManager : BaseManager<PocoDestekServis,MPDESTEKSERVİS> , IDestekServis
    {
        IDestekServisDal _destekServisDal;
        IMapper _mapper;

        public DestekServisManager(IMapper mapper, IDestekServisDal destekServisDal) : base(mapper, destekServisDal)
        {
            _destekServisDal = destekServisDal;
            _mapper = mapper;
        }


        public PocoDestekServis EkleyadaGuncelle(PocoDestekServis pModel)
        {
            return _mapper.Map<MPDESTEKSERVİS, PocoDestekServis>(_destekServisDal.EkleyadaGuncelle(_mapper.Map<PocoDestekServis, MPDESTEKSERVİS>(pModel)));
        }

    }
}
