﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.ARAC
{
    public class PocoARACRUHSATRESIM:SUPERPOCOMODEL
    {
        public int aracid { get; set; }
        public int num { get; set; }
        public string dosyatip { get; set; }

        [MaxLength, Column(TypeName = "ntext")]
        public string img { get; set; }
    }
}
