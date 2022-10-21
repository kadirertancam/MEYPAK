using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
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
    internal class DepoCekiListManager : BaseManager<PocoDEPOCEKILIST,MPDEPOCEKILIST>, IDepoCekiListServis
    {
        IDepoCekiListDal _depoCekiListDal;
        IMapper _mapper;
        public DepoCekiListManager(IMapper mapper ,IDepoCekiListDal depoCekiListDal) : base(mapper,depoCekiListDal)
        {
            _depoCekiListDal = depoCekiListDal;
            _mapper = mapper;
        }

        public PocoDEPOCEKILIST EkleyadaGuncelle(PocoDEPOCEKILIST entity)
        {
            return _mapper.Map<MPDEPOCEKILIST, PocoDEPOCEKILIST>(_depoCekiListDal.EkleyadaGuncelle(_mapper.Map<PocoDEPOCEKILIST,MPDEPOCEKILIST>(entity)));
        }
    }
}
