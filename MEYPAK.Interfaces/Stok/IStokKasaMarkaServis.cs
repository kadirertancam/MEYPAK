﻿using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokKasaMarkaServis:IGenericServis<PocoSTOKKASAMARKA>
    {
        public PocoSTOKKASAMARKA EkleyadaGuncelle(PocoSTOKKASAMARKA entity);
    }
}
