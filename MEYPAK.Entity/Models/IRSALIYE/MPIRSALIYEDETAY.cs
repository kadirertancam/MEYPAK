using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.SIPARIS;
using System.Text.Json.Serialization;

namespace MEYPAK.Entity.Models.IRSALIYE
{
    public class MPIRSALIYEDETAY:SUPERMODEL
    {
        public int IRSALIYEID { get; set; }
        [DefaultValue(0)]
        public int STOKID { get; set; } = 0;
        public int BIRIMID { get; set; }
        [DefaultValue(0)]
        public int DOVIZID { get; set; } = 0;
        [DefaultValue(0)]
        public int LISTEFIYATID { get; set; } = 0;
        [DefaultValue(0)]
        public int KULLANICIID { get; set; } = 0;
        [DefaultValue(0)]
        public int KASAID { get; set; } = 0;

        public byte TIP { get; set; } = 0;
        [StringLength(50)]
        
        public string STOKADI { get; set; } = "";
        [StringLength(200)]
        [DefaultValue("")]
        public string ACIKLAMA { get; set; } = "";
        public decimal MIKTAR { get; set; } = 0;
        public decimal ISTKONTO1 { get; set; } = 0;
        public decimal ISTKONTO2 { get; set; } = 0;
        public decimal ISTKONTO3 { get; set; } = 0;
        public decimal NETFIYAT { get; set; } = 0;
        public decimal BRUTFIYAT { get; set; } = 0;
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public int BEKLEYENMIKTAR { get; set; } = 0;
        public byte HAREKETDURUMU { get; set; } = 0;

        public decimal KDV { get; set; } = 0;
        public decimal KDVTUTARI { get; set; } = 0;
        public string KUNYE { get; set; }


    }
}
