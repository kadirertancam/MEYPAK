using AutoMapper;
using MEYPAK.BLL.Assets;
using MEYPAK.DAL.Abstract;
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
    public class KrediKartManager : BaseManager<PocoKREDIKART, MPKREDIKART>, IKrediKartServis
    {
        public KrediKartManager(IMapper mapper, IKrediKartiDal repo) : base(mapper, repo)
        {
        }
    }
}
