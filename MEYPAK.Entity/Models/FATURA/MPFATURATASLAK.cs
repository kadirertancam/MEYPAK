using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.FATURA
{
    public class MPFATURATASLAK:SUPERMODEL
    {
        public string TASLAKADI { get; set; }
        public int IRSALIYEID { get; set; } = 0;
        [DefaultValue(0)]
        public int SIRKETID { get; set; } = 0;
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

        public DateTime FATURATARIHI { get; set; } = DateTime.Now;
        public DateTime VADETARIHI { get; set; } = DateTime.Now;
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
        public bool KDVDAHIL { get; set; }
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal KDVTOPLAM { get; set; } = 0;
        public decimal ALTISKONTO1 { get; set; } = 0;
        public decimal ALTISKONTO2 { get; set; } = 0;
        public decimal ALTISKONTO3 { get; set; } = 0;
        public decimal ISKONTOTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public decimal GENELTOPLAM { get; set; } = 0;
        public int ARACID { get; set; }
        public int PERSONELID { get; set; }
        public int TIP { get; set; }
        public bool DURUM { get; set; }
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");
    }
}
