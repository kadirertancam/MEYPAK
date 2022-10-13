using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoManager :BaseManager<MPDEPO>, IDepoServis
    {
        IDepoDal _depoDal;

        public DepoManager(IDepoDal generic) : base(generic)
        {
            _depoDal = generic;
        }


        public Durum EkleyadaGuncelle(MPDEPO entity)
        {
            return _depoDal.EkleyadaGuncelle(entity);
        }

    }
}
