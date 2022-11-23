using AutoMapper;
using MEYPAK.DAL.Abstract.FaturaDal;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Interfaces.Fatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.FATURA
{
    public class FaturaDetayManager : BaseManager<PocoFATURADETAY, MPFATURADETAY>, IFaturaDetayServis
    {
        IFaturaDetayDal _faturaDetayDal;
        IMapper _mapper;

        public FaturaDetayManager(IMapper mapper, IFaturaDetayDal faturaDetayDal) : base(mapper, faturaDetayDal)
        {
            _faturaDetayDal = faturaDetayDal;
            _mapper = mapper;
        }


        public PocoFATURADETAY EkleyadaGuncelle(PocoFATURADETAY pModel)
        {
            return _mapper.Map<MPFATURADETAY, PocoFATURADETAY>(_faturaDetayDal.EkleyadaGuncelle(_mapper.Map<PocoFATURADETAY, MPFATURADETAY>(pModel)));

        }
    }
}
