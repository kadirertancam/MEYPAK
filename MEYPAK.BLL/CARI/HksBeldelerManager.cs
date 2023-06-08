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
    public class HksBeldelerManager : BaseManager<PocoHKSBELDELER, MPHKSBELDELER>, IHksBeldelerServis
    {
        IMapper _mapper;
        IHksBeldelerDal _hksBeldelerDal;
        public HksBeldelerManager(IMapper mapper, IHksBeldelerDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            _mapper= mapper;
            _hksBeldelerDal= repo;

        }
    }
}
