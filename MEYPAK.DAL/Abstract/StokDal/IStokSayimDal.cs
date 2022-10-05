using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokSayimDal : IGeneric<MPSTOKSAYIM>
    {

        public Durum EkleyadaGuncelle(MPSTOKSAYIM entity);
    }
}
