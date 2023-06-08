using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.ParametreDal;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PARAMETRE
{
    public class SeriYetkiManager : BaseManager<PocoSERIYETKI, MPSERIYETKI>, ISeriYetkiServis
    {
        IMapper _mapper;
        ISeriYetkiDal seriYetkiDal;
        public SeriYetkiManager(IMapper mapper, ISeriYetkiDal repo) : base(mapper, repo)
        {
            _mapper = mapper;
            seriYetkiDal = repo;
        }
    }
}
