using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.PersonelDal
{
    public interface IPersonelBankaDal:IGeneric<MPPERSONELBANKA>
    {
        public MPPERSONELBANKA EkleyadaGuncelle(MPPERSONELBANKA entity);
    }
}
