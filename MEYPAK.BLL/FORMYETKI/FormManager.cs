using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.FormYetkiDal;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Interfaces.FormYetki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.FORMYETKI
{
    public class FormManager : BaseManager<PocoFORM, MPFORM>, IFormServis
    {
        IFormDal formDal;
        public FormManager(IMapper mapper, IFormDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            formDal = repo;
        }
    }
}
