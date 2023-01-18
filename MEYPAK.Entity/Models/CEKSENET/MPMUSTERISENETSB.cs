using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CEKSENET
{
    public class MPMUSTERISENETSB:SUPERMODEL
    {
        public int USTID { get; set; }
        public string BORDRONO { get; set; }
        public int SENETNO { get; set; }
        public int CARIID { get; set; }
        public DateTime GIRISTAR { get; set; }
        public int ASIL { get; set; }
        public int CIROEDEN { get; set; }
        public DateTime VADETARIHI { get; set; }
        public DateTime ODEMETARIHI { get; set; }
        public int TUTAR { get; set; }
        public int DOVIZID { get; set; }
        public decimal KUR { get; set; }
        public decimal DOVIZTUTAR { get; set; }
        public int YERI { get; set; }
        public int MUHASEBEID { get; set; }
        public int ISLEM { get; set; }
        public int DURUM { get; set; }
        public string ACIKLAMA1 { get; set; }
        public string ACIKLAMA2 { get; set; }
        public int AKTIF { get; set; }
        public int VERILENID { get; set; }
        public int SONUSTID { get; set; }
        public int VERBORDRONO { get; set; }
        public int CIROCARIID { get; set; }
        public int CIROBANKAID { get; set; }
        public int ISLEMTIPI { get; set; }
        public int CIROEDENVKNTC { get; set; }
    }
}
