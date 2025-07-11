﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.MUSTAHSIL
{
    public class PocoMUSTAHSILCARI:SUPERPOCOMODEL
    {
        public string KOD { get; set; }
        public string TCNO { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }

        public string ADISOYADI
        {
            get
            {
                return ADI +" "+ SOYADI;
            }
        }
        public string IL { get; set; } = "";
        public string ILCE { get; set; } = "";
        public string POSTAKODU { get; set; } = "";
        public string TELEFON1 { get; set; } = "";
        public string TELEFON2 { get; set; } = "";
    }
}
