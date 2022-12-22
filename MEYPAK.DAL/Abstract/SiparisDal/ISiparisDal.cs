using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.SiparisDal
{
    public interface ISiparisDal:IGeneric<MPSIPARIS>
    {

        public List<MPSIPARIS> PagingList(int skip, int take);

    }
}
