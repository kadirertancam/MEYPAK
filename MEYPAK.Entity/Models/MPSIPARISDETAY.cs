using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPSIPARISDETAY
    {
        public int ID { get; set; }
        public int SIPARISID { get; set; }
        [DefaultValue(0)]
        public int BIRIMID { get; set; }
        [DefaultValue(0)]
        public int STOKID { get; set; }
        [DefaultValue(0)]
        public int DOVIZID { get; set; }
        [DefaultValue(0)]
        public int LISTEFIYATID { get; set; }
        [DefaultValue(0)]
        public int KULLANICIID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public byte TIP { get; set; }
        [StringLength(50)]
        public string STOKADI { get; set; }
        [StringLength(200)]
        public string ACIKLAMA { get; set; }
        public int MIKTAR { get; set; }
        public decimal ISTKONTO1 { get; set; }
        public decimal ISTKONTO2 { get; set; }
        public decimal ISTKONTO3 { get; set; }
        public decimal NETFIYAT { get; set; }
        public decimal BRUTFIYAT { get; set; }
        public decimal NETTOPLAM { get; set; }
        public decimal BRUTTOPLAM { get; set; }
        public int BEKLEYENMIKTAR { get; set; }
        public byte HARIKETDURUMU { get; set; }
        public byte KAYITTIPI { get; set; }
        public int KDV { get; set; }


        [ForeignKey("SIPARISID")]
        public MPSIPARIS SIPARIS { get; set; }
    }
}
