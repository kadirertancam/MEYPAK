﻿using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokResimServis:IGenericServis<PocoSTOKRESIM>
    { 
        public PocoSTOKRESIM EkleyadaGuncelle(PocoSTOKRESIM entity);
    }
}
