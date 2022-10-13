using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.IrsaliyeDal
{
    public interface IIrsaliyeDal : IGeneric<MPIRSALIYE>
    {

        public Durum EkleyadaGuncelle(MPIRSALIYE entity);
    }
}
