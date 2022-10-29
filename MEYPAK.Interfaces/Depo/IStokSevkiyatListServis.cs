using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IStokSevkiyatListServis:IGenericServis<PocoSTOKSEVKIYATLIST>
    {
        public PocoSTOKSEVKIYATLIST EkleyadaGuncelle(PocoSTOKSEVKIYATLIST entity);
      
    }
}
