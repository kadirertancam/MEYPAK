using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokFiyatDal : IGeneric<MPSTOKFIYAT>
    {

        public List<MPSTOKFIYAT> PagingList(int skip, int take);
    }
}
