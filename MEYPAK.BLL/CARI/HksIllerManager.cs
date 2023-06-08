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
    public class HksIllerManager:BaseManager<PocoHKSILLER,MPHKSILLER>, IHksIllerServis
    {
        IHksIllerDal _hksIllerDal;
        IMapper _mapper;

        public HksIllerManager(IMapper mapper, IHksIllerDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            _hksIllerDal = repo;

        }
    }
}
