using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.CariDal
{
    public interface ICariKartDal:IGeneric<MPCARIKART>
    {
        public MPCARIKART EkleyadaGuncelle(MPCARIKART entity);

        public List<MPCARIKART> PagingList(int skip, int take);

    }
}
