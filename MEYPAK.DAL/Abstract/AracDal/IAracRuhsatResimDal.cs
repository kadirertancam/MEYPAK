using MEYPAK.Entity.Models.ARAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.AracDal
{
    public interface IAracRuhsatResimDal : IGeneric<MPARACRUHSATRESIM>
    {
        public MPARACRUHSATRESIM EkleyadaGuncelle(MPARACRUHSATRESIM entity);
    }
}
