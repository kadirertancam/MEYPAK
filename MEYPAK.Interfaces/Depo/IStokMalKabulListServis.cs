using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IStokMalKabulListServis:IGenericServis<MPSTOKMALKABULLIST>
    {
        public Durum EkleyadaGuncelle(MPSTOKMALKABULLIST entity);
        public void OnYukle();
    }
}
