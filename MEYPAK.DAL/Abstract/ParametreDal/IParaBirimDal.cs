using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.PARAMETRE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.ParametreDal
{
    public interface IParaBirimDal:IGeneric<MPPARABIRIM>
    {
        public MPPARABIRIM EkleyadaGuncelle(MPPARABIRIM entity);
    }
}
