using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DekontDal;
using MEYPAK.Entity.Models.DEKONT;
using MEYPAK.Entity.PocoModels.DEKONT;
using MEYPAK.Interfaces.Dekont;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEKONT
{
    public class DekontManager : BaseManager<PocoDEKONT, MPDEKONT>,IDekontServis
    {
        IMapper _mapper;
        IDekontDal dekontDal;
        public DekontManager(IMapper mapper, IDekontDal repo ) : base(mapper, repo)
        {
            _mapper = mapper;
            dekontDal = repo;
        }
    }
}
