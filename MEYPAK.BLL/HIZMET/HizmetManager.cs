using MEYPAK.BLL.STOK;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Hizmet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.HIZMET
{
    public class HizmetManager :BaseManager<MPHIZMET>, IHizmetServis
    {
        IHizmetDal _hizmetDal;

        public HizmetManager(IHizmetDal generic) : base(generic)
        {
            _hizmetDal = generic;
        }


        public Durum EkleyadaGuncelle(MPHIZMET entity)
        {
            throw new NotImplementedException();
        }


    }
}
