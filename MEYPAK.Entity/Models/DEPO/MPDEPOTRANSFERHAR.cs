﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.STOK;
using System.Text.Json.Serialization;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPDEPOTRANSFERHAR:SUPERMODEL
    {
   
        [Required]
        public int DEPOTRANSFERID { get; set; }
        [Required]
        public int STOKID { get; set; }
        public int MIKTAR { get; set; }
        //BİRİM ID EKLENECEK.

        public byte DURUM { get; set; }
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");



    }
}
