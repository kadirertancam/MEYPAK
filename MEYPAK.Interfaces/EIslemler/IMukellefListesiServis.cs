﻿using MEYPAK.Entity.PocoModels.EISLEMLER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.EIslemler
{
    public interface IMukellefListesiServis:IGenericServis<PocoMUKELLEFLISTESI>
    {
        public PocoMUKELLEFLISTESI EkleyadaGuncelle(PocoMUKELLEFLISTESI entity);
    }
}
