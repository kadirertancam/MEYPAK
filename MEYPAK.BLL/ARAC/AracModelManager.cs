using AutoMapper;
using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.ARAC
{
    public class AracModelManager : BaseManager<PocoARACMODEL, MPARACMODEL>, IAracModelServis
    {
        IAracModelDal _aracmodelDal;
        IMapper _mapper;

        public AracModelManager(IMapper mapper, IAracModelDal aracmodelDal) : base(mapper, aracmodelDal)
        {
            _aracmodelDal = aracmodelDal;
            _mapper = mapper;
        }
    }
}
