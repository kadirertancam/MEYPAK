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
        public int SIRKETID { get; set; }=0;
        [DefaultValue(0)]
        public int SUBEID { get; set; } = 0;
        [DefaultValue(0)]
        public int DEPOID { get; set; } = 0;
        [DefaultValue(0)]
        public int CARIID { get; set; } = 0;
        [DefaultValue(0)]
        public int ALTHESAPID { get; set; } = 0;
        [DefaultValue(0)]
        public int KULLANICIID { get; set; } = 0;
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public DateTime SIPARISTARIHI { get; set; } = DateTime.Now; 
        public DateTime SEVKIYATTARIHI { get; set; }=DateTime.Now;
        public DateTime VADETARIHI { get; set; } = DateTime.Now;
        public byte TIP { get; set; } = 0;
        public byte KULLANICITIPI { get; set; } = 0;
        [StringLength(50)]
        public string CARIADI { get; set; } = "";
        public int VADEGUNU { get; set; } = 0;
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        [StringLength(200)]
        public string EKACIKLAMA { get; set; } = "";
        [DefaultValue(0)]
        public int DOVIZID { get; set; } = 0;
        public decimal KUR { get; set; } = 0;

        [StringLength(50)]
        public string SERINO { get; set; } = "";
        public string BELGENO { get; set; } = "";
        public bool KDVDAHİL { get; set; } = false;
        public decimal ISKONTO { get; set; } = 0;
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal KDVTOPLAM { get; set; }= 0;
        public decimal ISKONTOTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public decimal GENELTOPLAM { get; set; } = 0;
        public bool DURUM { get; set; } = false;


    }
}
