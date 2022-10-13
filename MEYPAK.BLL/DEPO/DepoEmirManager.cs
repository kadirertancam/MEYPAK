using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoEmirManager : BaseManager<MPDEPOEMIR>, IDepoEmirServis
    {
        IDepoEmirDal context;

        public DepoEmirManager(IDepoEmirDal generic) : base(generic)
        {
            context = generic;
        }
    }
}
