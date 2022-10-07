using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MEYPAK.Entity.Models
{
    public class MPSIPARIS
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DefaultValue(0)]
        public int SIRKETID { get; set; }
        [DefaultValue(0)]
        public int SUBEID { get; set; }
        [DefaultValue(0)]
        public int DEPOID { get; set; }
        [DefaultValue(0)]
        public int CARIID { get; set; }
        [DefaultValue(0)]
        public int ALTHESAPID { get; set; }
        [DefaultValue(0)]
        public int KULLANICIID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public DateTime SIPARISTARIHI { get; set; } 
        public DateTime SEVKIYATTARIHI { get; set; }
        public DateTime VADETARIHI { get; set; }
        public byte TIP { get; set; }
        public byte KULLANICITIPI { get; set; }
        [StringLength(50)]
        public string CARIADI { get; set; }
        public int VADEGUNU { get; set; } = 0;
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        [StringLength(200)]
        public string EKACIKLAMA { get; set; } = "";
        [DefaultValue(0)]
        public int DOVIZID { get; set; }
        public decimal KUR { get; set; }

        [StringLength(50)]
        public string SERINO { get; set; } = "";
        public string BELGENO { get; set; } = "";
        public bool KDVDAHİL { get; set; } 
        public decimal ISKONTO { get; set; }= 0;
        public decimal NETTOPLAM { get; set; }=0;
        public decimal KDVTOPLAM { get; set; } = 0;
        public decimal ISKONTOTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public decimal GENELTOPLAM { get; set; } = 0;
        public bool DURUM { get; set; }
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");


    }
}
