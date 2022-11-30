using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.HizmetDal
{
    public interface IHizmetKategoriDal:IGeneric<MPHIZMETKATEGORI>
    {
        public MPHIZMETKATEGORI EkleyadaGuncelle(MPHIZMETKATEGORI entity);
    }
}
