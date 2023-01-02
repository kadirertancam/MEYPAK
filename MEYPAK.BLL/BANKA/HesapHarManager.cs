using AutoMapper;
using MEYPAK.DAL.Abstract.BankaDal;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Interfaces.Banka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.BANKA
{
    public class HesapHarManager : BaseManager<PocoHESAPHAREKET, MPHESAPHAREKET>, IHesapHarServis
    {
        IHesapHarDal _bankaDal;
        IMapper _mapper;
        public HesapHarManager(IMapper mapper, IHesapHarDal repo) : base(mapper, repo)
        {
            _bankaDal = repo;
            _mapper = mapper;
        }
    }
}
