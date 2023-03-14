using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.EIslemlerDal;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Interfaces.EIslemler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.EISLEMLER
{
    public class GidenMustahsilMakbuzlariManager : BaseManager<PocoGIDENMUSTAHSILMAKBUZLARI, MPGIDENMUSTAHSILMAKBUZLARI>, IGidenMustahsilMakbuzlariServis
    {
        public GidenMustahsilMakbuzlariManager(IMapper mapper, IGidenMustahsilMakbuzlariDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
