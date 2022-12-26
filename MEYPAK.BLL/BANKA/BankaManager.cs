using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.BankaDal;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Banka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.BANKA
{
    public class BankaManager : BaseManager<PocoBANKA, MPBANKA>, IBankaServis
    {
        IBankaDal _bankaDal;
        IMapper _mapper;
        public BankaManager(IMapper mapper, IBankaDal repo) : base(mapper, repo)
        {
            _bankaDal = repo;
            _mapper = mapper;
        }
        public PocoBANKA EkleyadaGuncelle(PocoBANKA entity)
        {
            return _mapper.Map<MPBANKA, PocoBANKA>(_bankaDal.EkleyadaGuncelle(_mapper.Map<PocoBANKA, MPBANKA>(entity)));
        }
    }
}
