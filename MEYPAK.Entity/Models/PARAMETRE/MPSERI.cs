﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PARAMETRE
{
    public class MPSERI:SUPERMODEL
    {
        public string SERINO { get; set; }
        public int TIP { get; set; }   //0-Efatura,1-EArşiv,2-EIrsaliye,3-EMüstahsil
    }
}
