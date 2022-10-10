using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class KasaManager : BaseManager<MPKASA>, IKasaServis
    {
        IKasaDal _kasaDal;
        public KasaManager(IKasaDal generic) : base(generic)
        {
            _kasaDal = generic;
        }
    }
}
