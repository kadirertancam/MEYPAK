using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class MarkaManager :BaseManager<MPMARKA>, IMarkaServis
    {
        IMarkaDal _markaDal;

        public MarkaManager(IMarkaDal generic) : base(generic)
        {
            _markaDal = generic;   
        }



        public Durum EkleyadaGuncelle(MPMARKA entity)
        {
            return _markaDal.EkleyadaGuncelle(entity);
        }

        
    }
}
