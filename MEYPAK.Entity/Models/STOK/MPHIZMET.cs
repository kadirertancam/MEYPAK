﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPHIZMET:SUPERMODEL
    {

        [StringLength(50)]
        [Required]
        public string KOD { get; set; }
        [StringLength(200)]
        public string ADI { get; set; } = "";
        public decimal KDV { get; set; } = 0;
        public decimal OTV { get; set; } = 0;
        [StringLength(50)]
        public string GRUPKODU { get; set; } = "";
        [StringLength(500)]
        public string ACIKLAMA { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA1 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA2 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA3 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA4 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA5 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA6 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA7 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA8 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA9 { get; set; } = "";
        public int KATEGORIID { get; set; } = 0;
        [StringLength(50)]
        public string RAPORKODU1 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU2 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU3 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU4 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU5 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU6 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU7 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU8 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU9 { get; set; } = "";

        public string MUHALIS { get; set; } = "";
        public string MUHSATIS { get; set; } = "";
        public string MUHIADE { get; set; } = "";
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");


    }
}
