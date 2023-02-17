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
    public class SoforManager : BaseManager<PocoSOFOR, MPSOFOR>, ISoforServis
    {
        ISoforDal _soforDal;
        IMapper _mapper;

        public SoforManager(IMapper mapper, ISoforDal soforDal) : base(mapper, soforDal)
        {
            _soforDal = soforDal;
            _mapper = mapper;
        }

        public PocoSOFOR EkleyadaGuncelle(PocoSOFOR entity)
        {
            return _mapper.Map<MPSOFOR, PocoSOFOR>(_soforDal.EkleyadaGuncelle(_mapper.Map<PocoSOFOR, MPSOFOR>(entity)));
        }
    }
}
