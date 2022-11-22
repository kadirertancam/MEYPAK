using AutoMapper;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.CARI
{
    public class CariDokumanManager : BaseManager< PocoCARIDOKUMAN, MPCARIDOKUMAN>, ICariDokumanServis
    {
        ICariDokumanDal _cariDokumanDal;
        IMapper _mapper;

        public CariDokumanManager(IMapper mapper, ICariDokumanDal repo) : base(mapper, repo)
        {
            _cariDokumanDal = repo;
            _mapper = mapper;
        }
      
        public PocoCARIDOKUMAN EkleyadaGuncelle(PocoCARIDOKUMAN entity)
        {
            return _mapper.Map<MPCARIDOKUMAN, PocoCARIDOKUMAN>(_cariDokumanDal.EkleyadaGuncelle(_mapper.Map<PocoCARIDOKUMAN, MPCARIDOKUMAN>(entity)));
        }
    }
}
