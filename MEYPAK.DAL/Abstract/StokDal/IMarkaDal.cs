using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract
{
    public interface IMarkaDal:IGeneric<MPMARKA>
    {

        public Durum EkleyadaGuncelle(MPMARKA entity);
    }
}
