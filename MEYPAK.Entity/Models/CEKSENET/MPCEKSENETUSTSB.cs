﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CEKSENET
{
    
    public class MPCEKSENETUSTSB:SUPERMODEL
    {
        public int BORDROTIP { get; set; } // 1 - FIRMACEKCEK = 2-FIRMASENET = 3 MUSTERICEK = 4 - MUSTERISENET
        public DateTime TARIH { get; set; }
        public string BORDRONO { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TOPLAM { get; set; }
        public int ORTVADE { get; set; }
        public DateTime ORTVADETARIH { get; set; }
        public string ACIKLAMA1 { get; set; } = "";
        public string ACIKLAMA2 { get; set; } = "";
        public int DOVIZID { get; set; }
        public int KUR { get; set; }
        public int CARIID { get; set; }
        public int ALTHESAPID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DOVIZTUTAR { get; set; }
        public int DONEM { get; set; }
    }
}
