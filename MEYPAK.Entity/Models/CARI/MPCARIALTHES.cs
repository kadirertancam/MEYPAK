﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    public class MPCARIALTHES:SUPERMODEL
    {
        
        public string ADI { get; set; }
        [DefaultValue(0)]
        public string KOD { get; set; }
        public int DOVIZID { get; set; } = 0;
        public int AKTIF { get; set; }



    }
}
