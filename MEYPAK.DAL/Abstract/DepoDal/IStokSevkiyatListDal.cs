using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IStokSevkiyatListDal:IGeneric<MPSTOKSEVKİYATLİST>
    {
        public Durum EkleyadaGuncelle(MPSTOKSEVKİYATLİST entity);
        public void OnYukle();
    }
}
