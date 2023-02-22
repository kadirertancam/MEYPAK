using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CEKSENET
{
    public class PocoMUSTERICEKSB : SUPERPOCOMODEL
    {
        public int USTID { get; set; }
        public string BORDRONO { get; set; }
        public string CEKNO { get; set; }
        public int CARIID { get; set; }
        public DateTime GIRISTAR { get; set; }
        public int ASIL { get; set; }
        public int CIROEDEN { get; set; }
        public DateTime VADETARIH { get; set; }
        public DateTime ODEMETARIH { get; set; }
        public decimal TUTAR { get; set; }
        public int DOVIZID { get; set; }
        public decimal KUR   { get; set; }
        public decimal DOVTUTAR { get; set; }
        public string BANKA { get; set; } = "";
        public string SUBE { get; set; } = "";
        public string HESAPNO { get; set; } = "";
        public int SERINO { get; set; } 
        public string IBANNO { get; set; } =  "";
        public int MUHASEBEID { get; set; }
        public int ISLEM { get; set; } //1 -CIRO 2- PROTESTO 3- TAHSÝLAT 4-TEMÝNAT
        public int DURUM { get; set; }
        public string ACIKLAMA1 { get; set; } = "";
        public string ACIKLAMA2 { get; set; } = "";
        public int AKTIF { get; set; }
        public string IL { get; set; } = "";
        public string ILCE { get; set; } = "";
        public int VERILENID { get; set; }
        public int VERILENBORDRONO { get; set; }
        public int SONUSTID { get; set; }
        public int CIROCARIID { get; set; }
        public int CIROBANKAID { get; set; }
        public int ISLTEMTIP { get; set; }
        public int CIROEDENVKNTC { get; set; }
    }
}
