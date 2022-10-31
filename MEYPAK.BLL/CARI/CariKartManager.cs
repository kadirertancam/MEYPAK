using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Cari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.CARI
{
    public class CariKartManager : BaseManager<PocoCARIKART, MPCARIKART>, ICariKartServis
    {
        ICariKartDal _cariKartDal;
        IMapper _mapper;
        public CariKartManager(IMapper mapper, ICariKartDal repo) : base(mapper, repo)
        {
            _cariKartDal= repo;
            _mapper = mapper;
        }
        public PocoCARIKART EkleyadaGuncelle(PocoCARIKART entity)
        {
            return _mapper.Map<MPCARIKART, PocoCARIKART>(_cariKartDal.EkleyadaGuncelle(_mapper.Map<PocoCARIKART, MPCARIKART>(entity)));
        }
    }
}
