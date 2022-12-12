using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Entity.Models.SIPARIS
{
    public class MPSIPARISDETAY:SUPERMODEL
    { 

        public int SIPARISID { get; set; }
        [DefaultValue(0)]
        public int IRSALIYEID { get; set; }=0;
        [DefaultValue(0)]
        public int BIRIMID { get; set; }
        [DefaultValue(0)]
        public int STOKID { get; set; }
        [DefaultValue(0)]
        public int DOVIZID { get; set; } = 0;
        [DefaultValue(0)]
        public int LISTEFIYATID { get; set; } = 0;
        [DefaultValue(0)]
        public int KULLANICIID { get; set; } = 0; 
        public int T_FLAG { get; set; } = 0;
        [DefaultValue(0)]
        public int KASAID { get; set; } = 0;
        public decimal DARALI { get; set; }
        public decimal DARA { get; set; }
        public decimal SAFI { get; set; }
        public decimal KASAMIKTAR { get; set; }

        public byte TIP { get; set; } = 0;
        [StringLength(50)]
        public string STOKADI { get; set; } = "";
        [StringLength(200)]
        [DefaultValue("")]
        public string ACIKLAMA { get; set; } = "";
        public decimal ISTKONTO1 { get; set; } = 0;
        public decimal ISTKONTO2 { get; set; } = 0;
        public decimal ISTKONTO3 { get; set; } = 0;
        public decimal ISKTOPLAM { get; set; } = 0;
        public decimal NETFIYAT { get; set; } = 0;
        public decimal BRUTFIYAT { get; set; } = 0;
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public int BEKLEYENMIKTAR { get; set; } = 0;
        public byte HAREKETDURUMU { get; set; } = 0;
        public decimal KDV { get; set; } = 0;
        public decimal KDVTUTARI { get; set; } = 0;
        public int NUM { get; set; } = 0;
   
    }
}
