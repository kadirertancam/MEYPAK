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
    public class FormYetkiManager : BaseManager<PocoFORMYETKI, MPFORMYETKI>, IFormYetkiServis
    {
        IFormYetkiDal formYetkiDal;
        public FormYetkiManager(IMapper mapper, IFormYetkiDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            formYetkiDal = repo;
        }
    }
}
