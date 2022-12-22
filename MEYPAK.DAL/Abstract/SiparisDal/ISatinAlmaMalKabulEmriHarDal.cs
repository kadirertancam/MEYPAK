using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.SiparisDal
{
    public interface ISatinAlmaMalKabulEmriHarDal:IGeneric<MPSATINALMAMALKABULEMRIHAR>
    {

        public List<MPSATINALMAMALKABULEMRIHAR> PagingList(int skip, int take);

    }
}
