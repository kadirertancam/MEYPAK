using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
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
        public MPSTOKMALKABULLIST EkleyadaGuncelle(MPSTOKMALKABULLIST entity);
        public List<MPSTOKMALKABULLIST> PagingList(int skip, int take);

    }
}
