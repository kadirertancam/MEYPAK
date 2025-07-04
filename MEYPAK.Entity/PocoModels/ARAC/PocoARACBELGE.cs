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
    public class PocoARACBELGE:SUPERPOCOMODEL
    {
        public int ARACID { get; set; }
        public int NUM { get; set; }
        [MaxLength, Column(TypeName = "ntext")]
        public string IMG { get; set; }
        public string BELGETIP { get; set; }
        public string ACIKLAMA { get; set; } = "";
    }
}
