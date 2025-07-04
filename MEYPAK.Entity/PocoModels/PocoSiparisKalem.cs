﻿using MEYPAK.Entity.Models;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoSiparisKalem
    {
       
        public int id { get; set; } 
        public int StokId { get; set; } 
        public string StokKodu { get; set; }
        public string StokAdı { get; set; } = ""; 
        public string Tipi { get; set; }
        public int KasaId { get; set; }
        public string KasaAdı { get; set; } = "";
        public string Acıklama { get; set; } = "";
        public string Birim { get; set; } = "";
        public decimal KasaMiktar { get; set; } = 0;
        public decimal Daralı { get; set; }
        public decimal Dara { get; set; }
        public decimal Safi { get; set; }
        public int Doviz { get; set; } = 11638;
        public decimal BirimFiyat { get; set; }=0;
        public decimal NetFiyat{ get; set; } = 0; 
        public decimal BrütFiyat { get; set; } = 0;
        public decimal İskonto1 { get; set; } = 0;
        public decimal İskonto2 { get; set; }= 0;
        public decimal İskonto3 { get; set; } = 0;
        public decimal Kdv { get; set; } = 0;
        public decimal KdvTutarı { get; set; }
        public decimal İskontoTutarı { get; set; }
        public decimal NetToplam { get; set; } = 0;
        public decimal BrütToplam { get; set; } = 0;
        public int sıra { get; set; }




    }
}
