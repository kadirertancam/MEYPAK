using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Cari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.CARI
{
    public class AdresListManager : BaseManager<PocoAdresList, ADRESLIST>, IAdresListServis
    {
        IAdresListDal _adresListDal;
        IMapper _mapper;
        public AdresListManager(IMapper mapper, IAdresListDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            _adresListDal= repo;
            _mapper = mapper;
        }
    }
}
