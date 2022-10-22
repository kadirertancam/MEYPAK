using MEYPAK.Entity.Models.SIPARIS;
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
    public class PocoIRSALIYE:SUPERPOCOMODEL
    {
        public int SIPARISID { get; set; }
        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; } = 0;
        public int CARIID { get; set; } = 0;
        public int ALTHESAPID { get; set; } = 0;
        public int KULLANICIID { get; set; } = 0;
        public DateTime IRSALIYETARIHI { get; set; } = DateTime.Now;
        public DateTime SEVKIYATTARIHI { get; set; } = DateTime.Now;
        public DateTime VADETARIHI { get; set; } = DateTime.Now;
        public byte KULLANICITIPI { get; set; } = 0;
        [StringLength(50)]
        public string CARIADI { get; set; } = "";
        public int VADEGUNU { get; set; } = 0;
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        [StringLength(200)]
        public string EKACIKLAMA { get; set; } = "";
        public int DOVIZID { get; set; } = 0;
        public decimal KUR { get; set; } = 0;
        [StringLength(50)]
        public string SERINO { get; set; } = "";
        public string BELGENO { get; set; } = "";
        public bool KDVDAHİL { get; set; }
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal KDVTOPLAM { get; set; } = 0;
        public decimal ISKONTOTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public decimal GENELTOPLAM { get; set; } = 0;
        public int ARACID { get; set; }
        public int PERSONELID { get; set; }
        public bool DURUM { get; set; }
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");
        public virtual PocoSIPARIS MPSIPARIS { get; set; }
    }
}
