using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{

    public class MPSTOKHAR
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public int HAREKETTURU { get; set; }        // 1SATIS-2ALIS-3SATISIADE-4ALISIADE-5MUHTELIF-6DAT-7Sayim
        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; } = 0;
        [StringLength(500)]
        public string ACIKLAMA { get; set; } = "";
        [StringLength(100)]
        public string BELGE_NO { get; set; } = "";
        public int FATURAID { get; set; } = 0;
        public decimal KDV { get; set; } = 0;
        public int IO { get; set; } = 0;
        public decimal NETFIYAT { get; set; } = 0;
        public decimal MIKTAR { get; set; } = 0;
        public int BIRIM { get; set; } = 0;
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public int SAYIMID { get; set; } = 0;
        public int KULLANICIID { get; set; } = 0;
        public byte KAYITTIPI { get; set; } = 0;
        [JsonIgnore]
        public MPSTOK MPSTOK { get; set; }


    }
}
