﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKSAYIMHAR:SUPERMODEL
    {
        public MPSTOKSAYIMHAR()
        {

        }
    
        public int FIRMAID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; }
        public int STOKSAYIMID { get; set; }
        public decimal MIKTAR { get; set; }
        public decimal FIYAT { get; set; }
        public int PARABR { get; set; } = 1;
        public decimal KUR { get; set; } = 1;

        public int STOKID { get; set; }
     
        public int BIRIMID { get; set; }


    }
}
