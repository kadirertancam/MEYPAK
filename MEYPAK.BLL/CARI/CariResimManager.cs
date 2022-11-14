using AutoMapper;
using MEYPAK.DAL.Abstract;
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
    public class CariResimManager:BaseManager<PocoCARIRESIM,MPCARIRESIM>,ICariResimServis
    {
        ICariResimDal _cariResimDal;
        IMapper _mapper;
        public CariResimManager(IMapper mapper, ICariResimDal repo) : base(mapper, repo)
        {
            _cariResimDal = repo;   
            _mapper = mapper;
        }

        public PocoCARIRESIM EkleyadaGuncelle(PocoCARIRESIM entity)
        {
            return _mapper.Map<MPCARIRESIM, PocoCARIRESIM>(_cariResimDal.EkleyadaGuncelle(_mapper.Map<PocoCARIRESIM, MPCARIRESIM>(entity)));
        }
    }
}
