using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IStokKategoriDal:IGeneric<MPSTOKKATEGORI>
    {
        public MPSTOKKATEGORI EkleyadaGuncelle(MPSTOKKATEGORI entity);

        public List<MPSTOKKATEGORI> PagingList(int skip, int take);

    }
}
