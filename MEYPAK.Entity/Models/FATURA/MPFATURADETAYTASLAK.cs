﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEYPAK.Entity.Models.FATURA
{
    public class MPFATURADETAYTASLAK:SUPERMODEL
    {
        public int FATURATASLAKID { get; set; }

        public int STOKID { get; set; }
        [DefaultValue(0)]
        public int BIRIMID { get; set; }
        [DefaultValue(0)]
        public int DOVIZID { get; set; } = 0;
        [DefaultValue(0)]
        public int LISTEFIYATID { get; set; } = 0;
        [DefaultValue(0)]
        public int KULLANICIID { get; set; } = 0;
        [DefaultValue(0)]
        public int NUM { get; set; }
        public byte TIP { get; set; } = 0;
        [StringLength(50)]
        public string STOKADI { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        public int TEVKIFATNO { get; set; } = 0;
        public int ISTISNANO { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal KASAMIKTAR { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal DARALI { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal DARA { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal SAFI { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ISKONTO1 { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ISKONTO2 { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ISKONTO3 { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ISKTOPLAM { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal BIRIMFIYAT { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal NETFIYAT { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal BRUTFIYAT { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal NETTOPLAM { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal BRUTTOPLAM { get; set; } = 0;
        public int BEKLEYENMIKTAR { get; set; } = 0;
        public byte HAREKETDURUMU { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal KDV { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal KDVTUTARI { get; set; } = 0;
        public string KUNYE { get; set; }

    }
}
