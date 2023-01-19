using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokSarfManager : BaseManager<PocoSTOKSARF, MPSTOKSARF>, IStokSarfServis
    {
        public StokSarfManager(IMapper mapper, IStokSarfDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
