using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokKasaManager : BaseManager<MPSTOKKASA>, IStokKasaServis
    {
        IStokKasaDal _kasaDal;
        public StokKasaManager(IStokKasaDal generic) : base(generic)
        {
            _kasaDal = generic;
        }
    }
}
