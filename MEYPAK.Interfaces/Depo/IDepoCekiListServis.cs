﻿using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoCekiListServis:IGenericServis<PocoDEPOCEKILIST>
    {
        public PocoDEPOCEKILIST EkleyadaGuncelle(PocoDEPOCEKILIST entity);
    }
}
