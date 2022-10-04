using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{

    public class MPSTOKHAR
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }=DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; }= DateTime.Now;
        public int HAREKETTURU { get; set; }        // 1SATIS-2ALIS-3SATISIADE-4ALISIADE-5MUHTELIF-6DAT 
        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; }
        [StringLength(500)]
        public string ACIKLAMA { get; set; }
        [StringLength(100)]
        public string BELGE_NO { get; set; }
        public int FATURAID { get; set; }
        public decimal KDV { get; set; } 
        public int IO { get; set; } 
        public decimal NETFIYAT { get; set; }
        public decimal MIKTAR { get; set; }
        public int BIRIM { get; set; } 
        public decimal NETTOPLAM { get; set; }
        public decimal BRUTTOPLAM { get; set; }
        public int KULLANICIID { get; set; } = 0;
        public byte KAYITTIPI { get; set; } = 0; 

        public MPSTOK MPSTOK { get; set; }

    }
}
