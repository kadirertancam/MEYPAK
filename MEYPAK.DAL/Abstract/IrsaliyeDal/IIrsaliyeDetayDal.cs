using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.IrsaliyeDal
{
    public interface IIrsaliyeDetayDal:IGeneric<MPIRSALIYEDETAY>
    {

        public Durum EkleyadaGuncelle(MPIRSALIYEDETAY entity);
    }
}
