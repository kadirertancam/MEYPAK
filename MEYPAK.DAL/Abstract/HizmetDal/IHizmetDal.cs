using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.HizmetDal
{
    public interface IHizmetDal : IGeneric<MPHIZMET>
    {
        public Durum EkleyadaGuncelle(MPHIZMET entity);

    }
}
