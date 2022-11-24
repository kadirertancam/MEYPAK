using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOK:SUPERMODEL
    {


        [DefaultValue(0)]
        public int SIRKETID { get; set; }
        [DefaultValue(0)]
        public int SUBEID { get; set; }

        [StringLength(50), Required]
        public string KOD { get; set; }
        [StringLength(200)]
        public string ADI { get; set; }
        [DefaultValue(0)]
        public int MARKAID { get; set; }
        [DefaultValue(0)]
        public int KATEGORIID { get; set; }
        [DefaultValue(0)]
        public int OLCUBR1 { get; set; }
        public int SDOVIZID { get; set; } = 1;
        public int ADOVIZID { get; set; } = 1;
        [DefaultValue(0)]
        public decimal SFIYAT1 { get; set; }
        [DefaultValue(0)]
        public decimal SFIYAT2 { get; set; }
        [DefaultValue(0)]
        public decimal SFIYAT3 { get; set; }
        [DefaultValue(0)]
        public decimal SFIYAT4 { get; set; }
        [DefaultValue(0)]
        public decimal SFIYAT5 { get; set; }
        [DefaultValue(0)]
        public decimal AFIYAT1 { get; set; }
        [DefaultValue(0)]
        public decimal AFIYAT2 { get; set; }
        [DefaultValue(0)]
        public decimal AFIYAT3 { get; set; }
        [DefaultValue(0)]
        public decimal AFIYAT4 { get; set; }
        [DefaultValue(0)]
        public decimal AFIYAT5 { get; set; }
        [DefaultValue(0)]
        public int SATISKDV { get; set; }
        [DefaultValue(0)]
        public int ALISKDV { get; set; }
        [DefaultValue(0)]
        public int SATISOTV { get; set; }
        [DefaultValue(0)]
        public int ALISOTV { get; set; }
        public string GRUPKODU { get; set; }
        [StringLength(500)]
        public string ACIKLAMA { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA1 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA2 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA3 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA4 { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA5 { get; set; } = "";
        [DefaultValue(0)]
        public int SACIKLAMA { get; set; }
        [DefaultValue(0)]
        public int SACIKLAMA1 { get; set; }
        [DefaultValue(0)]
        public int SACIKLAMA2 { get; set; }
        [DefaultValue(0)]
        public int SACIKLAMA3 { get; set; }
        [DefaultValue(0)]
        public int SACIKLAMA4 { get; set; }
        [DefaultValue(0)]
        public int SACIKLAMA5 { get; set; }
        [StringLength(50), DefaultValue("")]
        public string RAPORKODU { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU1 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU2 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU3 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU4 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU5 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU6 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU7 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU8 { get; set; } = "";
        [StringLength(50)]
        public string RAPORKODU9 { get; set; } = "";
        public int GTIN { get; set; }
        [DefaultValue(0)]
        public int KULLANICIID { get; set; }
         
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");



    }
}
