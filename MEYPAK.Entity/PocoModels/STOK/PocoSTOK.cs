using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.DEPO;
using System.Text.Json.Serialization;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOK:SUPERPOCOMODEL
    {
        
     
        public int sirketid { get; set; }
        public int subeid { get; set; }
        public string kod { get; set; } = "";
        public string adi { get; set; } = "";
        public int markaid { get; set; }
        public int kategoriid { get; set; }
        public int olcubR1 { get; set; }
        public int sdovizid { get; set; }
        public int adovizid { get; set; }
        public decimal sfiyaT1 { get; set; }
        public decimal sfiyaT2 { get; set; }
        public decimal sfiyaT3 { get; set; }
        public decimal sfiyaT4 { get; set; }
        public decimal sfiyaT5 { get; set; }
        public decimal afiyaT1 { get; set; }
        public decimal afiyaT2 { get; set; }
        public decimal afiyaT3 { get; set; }
        public decimal afiyaT4 { get; set; }
        public decimal afiyaT5 { get; set; }
        public decimal satiskdv { get; set; }
        public decimal aliskdv { get; set; }
        public decimal satisotv { get; set; }
        public decimal alisotv { get; set; }
        public string grupkodu { get; set; }
        public string aciklama { get; set; } = "";
        public string aciklamA1 { get; set; } = "";
        public string aciklamA2 { get; set; } = "";
        public string aciklamA3 { get; set; } = "";
        public string aciklamA4 { get; set; } = "";
        public string aciklamA5 { get; set; } = "";
        public decimal saciklama { get; set; } = 0;
        public decimal saciklamA1 { get; set; } = 0;
        public decimal saciklamA2 { get; set; } = 0;
        public decimal saciklamA3 { get; set; } = 0;
        public decimal saciklamA4 { get; set; } = 0;
        public decimal saciklamA5 { get; set; } = 0;
        public string raporkodu { get; set; } = "";
        public string raporkodU1 { get; set; } = "";
        public string raporkodU2 { get; set; } = "";
        public string raporkodU3 { get; set; } = "";
        public string raporkodU4 { get; set; } = "";
        public string raporkodU5 { get; set; } = "";
        public string raporkodU6 { get; set; } = "";
        public string raporkodU7 { get; set; } = "";
        public string raporkodU8 { get; set; } = "";
        public string raporkodU9 { get; set; } = "";
        public int gtin { get; set; }
        public int kullaniciid { get; set; }
        public string donem { get; set; }
    }
}
