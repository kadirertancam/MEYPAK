﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{

    public class MPSTOKHAR:SUPERMODEL
    {

        [Required]
        public int STOKID { get; set; }
        public int HAREKETTURU { get; set; }        // 1SATISFATURA-2ALISFATURA-3SATISIRSALIYE-4ALISIRSALIYE-5SATIFATURAIADE-6ALISFATURAIADE-7SATISIRSALIYEIADE-8ALISIRSALIYEIADE-9MUHTELIF-10DAT-11Sayim-12SARF
        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; } = 0;
        [StringLength(500)]
        public string ACIKLAMA { get; set; } = "";
        [StringLength(100)]
        public string BELGE_NO { get; set; } = "";
        public int FATURAID { get; set; } = 0;
        public int FATURADETAYID { get; set; } = 0;
        public int MUSTAHSILID { get; set; } = 0;
        public int MUSTAHSILDETAYID { get; set; } = 0;
        public int IRSALIYEID  { get; set; } = 0;
        public int IRSALIYEDETAYID  { get; set; } = 0;
        public int SARFID { get; set; } = 0;
        public int SARFDETAYID { get; set; } = 0;
        public decimal KDV { get; set; } = 0;
        public int IO { get; set; } = 0;
        public decimal NETFIYAT { get; set; } = 0;
        public decimal MIKTAR { get; set; } = 0;
        public int BIRIM { get; set; } = 0;
       
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public int SAYIMID { get; set; } = 0;
        public int KULLANICIID { get; set; } = 0;
        public string KUNYE { get; set; } = "";



    }
}
