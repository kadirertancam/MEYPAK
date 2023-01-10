using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CEKSENET
{
    public class PocoFIRMACEKSB : SUPERPOCOMODEL
    {
        public int USTID { get; set; }
        public int BORDRONO { get; set; }
        public string CEKNO { get; set; }
        public int CARIID { get; set; }
        public DateTime CIKISTARIH { get; set; }
        public DateTime VADETARIH { get; set; }
        public DateTime ODEMETARIH { get; set; }
        public decimal TUTAR { get; set; }
        public int DOVIZID { get; set; }
        public decimal KUR { get; set; }
        public decimal DOVIZTUTAR { get; set; }
        public string BANKA { get; set; }
        public string SUBE { get; set; }
        public string HESAPNO { get; set; }
        public int SERINO { get; set; }
        public string IBANNO { get; set; }
        public int MUHASEBEID { get; set; }
        public int ISLEM { get; set; }
        public int DURUM { get; set; }
        public string ACIKLAMA1 { get; set; }
        public string ACIKLAMA2 { get; set; }
        public int AKTIF { get; set; }
        public int BANKAID { get; set; }
        public int SONUSTID { get; set; }
        public int ISLEMTIPI { get; set; }
    }
}
