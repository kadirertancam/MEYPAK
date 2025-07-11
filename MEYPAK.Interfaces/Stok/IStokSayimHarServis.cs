﻿using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokSayimHarServis:IGenericServis<PocoSTOKSAYIMHAR>
    {
        public PocoSTOKSAYIMHAR EkleyadaGuncelle(PocoSTOKSAYIMHAR entity);

        public List<PocoSTOKSAYIMHAR> PagingList(int skip, int take);
    }
}
