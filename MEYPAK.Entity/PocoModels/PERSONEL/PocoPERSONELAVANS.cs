﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PERSONEL
{
    public class PocoPERSONELAVANS:SUPERPOCOMODEL
    {
        public int PERSONELID { get; set; }
        public decimal MIKTAR { get; set; }
        public DateTime TARIH { get; set; }
        public string ACIKLAMA { get; set; } = "";
    }
}
