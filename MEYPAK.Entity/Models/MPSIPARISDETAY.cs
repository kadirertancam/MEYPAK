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
        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }
        [DefaultValue(0)]
        public int DOVIZID { get; set; }=0;
        [DefaultValue(0)]
        public int LISTEFIYATID { get; set; } = 0;
        [DefaultValue(0)]
        public int KULLANICIID { get; set; } = 0;
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public byte TIP { get; set; } = 0;
        [StringLength(50)]
        public string STOKADI { get; set; } = "";
        [StringLength(200)]
        [DefaultValue("")]
        public string ACIKLAMA { get; set; } = "";
        public decimal MIKTAR { get; set; } = 0;
        public decimal ISTKONTO1 { get; set; }=0;
        public decimal ISTKONTO2 { get; set; }= 0;
        public decimal ISTKONTO3 { get; set; } = 0;
        public decimal NETFIYAT { get; set; } = 0;
        public decimal BRUTFIYAT { get; set; } = 0;
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public int BEKLEYENMIKTAR { get; set; } = 0;
        public byte HARIKETDURUMU { get; set; } = 0;
        public byte KAYITTIPI { get; set; } = 0;
        public decimal KDV { get; set; } = 0;
        public decimal KDVTUTARI { get; set; } = 0;


        [ForeignKey("SIPARISID")]
        public MPSIPARIS SIPARIS { get; set; }

        public MPSTOK MPSTOK { get; set; }
    }
}
