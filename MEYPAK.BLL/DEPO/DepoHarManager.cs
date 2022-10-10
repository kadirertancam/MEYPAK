using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoHarManager : BaseManager<MPDEPOHAR>, IDepoHarServis
    {
        IDepoHarDal depoHarDal;

        public DepoHarManager(IDepoHarDal generic) : base(generic)
        {
            depoHarDal = generic;
        }

        public Durum Guncelle(MPDEPOHAR entity)
        {
            throw new NotImplementedException();
        }
    }
}
