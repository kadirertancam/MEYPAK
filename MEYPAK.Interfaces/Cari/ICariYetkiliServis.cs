﻿using MEYPAK.Entity.PocoModels.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Cari
{
    public interface ICariYetkiliServis :IGenericServis<PocoCARIYETKILI>
    {
        public PocoCARIYETKILI EkleyadaGuncelle(PocoCARIYETKILI entity);
    }
}
