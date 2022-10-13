using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class OlcuBrManager :BaseManager<MPOLCUBR> ,IOlcuBrServis
    {
        IOlcuBrDal _olcuBrDal;

        public OlcuBrManager(IOlcuBrDal generic) : base(generic)
        {
            _olcuBrDal = generic;
        }


        public Durum EkleyadaGuncelle(MPOLCUBR entity)
        {
            return _olcuBrDal.EkleyadaGuncelle(entity);
        }

       
    }
}
