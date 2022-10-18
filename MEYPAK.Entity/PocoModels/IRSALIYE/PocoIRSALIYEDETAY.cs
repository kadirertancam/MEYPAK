using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.PocoModels.SIPARIS;

namespace MEYPAK.Entity.PocoModels.IRSALIYE
{
    public class PocoIRSALIYEDETAY
    {
        public int ID { get; set; }
        public int SIPARISID { get; set; }
        public int BIRIMID { get; set; }
        public int DOVIZID { get; set; } = 0;
        public int LISTEFIYATID { get; set; } = 0;
        public int KULLANICIID { get; set; } = 0;
        public int KASAID { get; set; } = 0;
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public byte TIP { get; set; } = 0;
        [StringLength(50)]
        public string STOKADI { get; set; } = "";
        [StringLength(200)]
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
        public byte KAYITTIPI { get; set; } = 0;
        public virtual PocoSIPARIS MPSIPARIS { get; set; }
    }
}
