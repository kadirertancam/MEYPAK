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
    public class CariYetkiliManager:BaseManager<PocoCARIYETKILI, MPCARIYETKILI>,ICariYetkiliServis
    {
        IMapper _mapper;
        ICariYetkiliDal _cariYetkiliServis;

        public CariYetkiliManager(IMapper mapper, ICariYetkiliDal cariYetkiliServis) : base(mapper, cariYetkiliServis)
        {
            _mapper = mapper;
            _cariYetkiliServis = cariYetkiliServis;
        }

        public PocoCARIYETKILI EkleyadaGuncelle(PocoCARIYETKILI entity)
        {
            return _mapper.Map<MPCARIYETKILI, PocoCARIYETKILI>(_cariYetkiliServis.EkleyadaGuncelle(_mapper.Map<PocoCARIYETKILI, MPCARIYETKILI>(entity)));
        }

    }
}
