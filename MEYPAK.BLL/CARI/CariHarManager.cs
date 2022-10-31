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
    public class CariHarManager : BaseManager<PocoCARIHAR,MPCARIHAR>, ICariHarServis
    {
        IMapper _mapper;
        ICariHarDal _cariHarDal;

        public CariHarManager(IMapper mapper, ICariHarDal repo) : base(mapper, repo)
        {
            _cariHarDal = repo;
            _mapper = mapper;
        }
    }
}
