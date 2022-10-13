using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokMarkaManager :BaseManager<MPSTOKMARKA>, IStokMarkaServis
    {
        IStokMarkaDal _markaDal;

        public StokMarkaManager(IStokMarkaDal generic) : base(generic)
        {
            _markaDal = generic;   
        }



        public Durum EkleyadaGuncelle(MPSTOKMARKA entity)
        {
            return _markaDal.EkleyadaGuncelle(entity);
        }

        
    }
}
