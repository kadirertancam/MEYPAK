using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IStokMalKKabulListDal:IGeneric<MPSTOKMALKABULLIST>
    {
        public Durum EkleyadaGuncelle(MPSTOKMALKABULLIST entity);
        public void OnYukle();
    }
}
