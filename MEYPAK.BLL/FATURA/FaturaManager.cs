using AutoMapper;
using MEYPAK.DAL.Abstract.FaturaDal;
using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Fatura;
using MEYPAK.Interfaces.Hizmet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.FATURA
{
    public class FaturaManager : BaseManager<PocoFATURA, MPFATURA>, IFaturaServis
    {
        IFaturaDal _faturaDal;
        IMapper _mapper;

        public FaturaManager(IMapper mapper, IFaturaDal faturaDal) : base(mapper, faturaDal)
        {
            _faturaDal = faturaDal;
            _mapper = mapper;
        }


        public PocoFATURA EkleyadaGuncelle(PocoFATURA pModel)
        {
            return _mapper.Map<MPFATURA, PocoFATURA>(_faturaDal.EkleyadaGuncelle(_mapper.Map<PocoFATURA, MPFATURA>(pModel)));

        }


    }
}
}
