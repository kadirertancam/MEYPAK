﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.EISLEMLER
{
    public class MPGIDENFATURALAR:SUPERMODEL
    {
        public DateTime TARIH { get; set; }
        public int FATURAID { get; set; }
        public string BELGENO { get; set; }
        public int TIP { get; set; }
        public string HATAKODU { get; set; }
        public int DURUM { get; set; }
        public string ETTNO { get; set; }
    }
}
