using AutoMapper;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoManager :BaseManager<PocoDEPO,MPDEPO>, IDepoServis
    {
        IDepoDal _depoDal;
        IMapper _mapper;

        public DepoManager(IMapper mapper,IDepoDal depoDal) : base(mapper,depoDal)
        {
            _depoDal = depoDal;
            _mapper = mapper;
        }


        public Durum EkleyadaGuncelle(PocoDEPO pModel)
        {
            return _depoDal.EkleyadaGuncelle(_mapper.Map<PocoDEPO,MPDEPO>(pModel));
        }

    }
}
