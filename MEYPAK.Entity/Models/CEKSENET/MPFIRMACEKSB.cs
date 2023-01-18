using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CEKSENET
{
    public class MPFIRMACEKSB:SUPERMODEL
    {
        public int USTID { get; set; }
        public string BORDRONO { get; set; }
        public int CEKNO { get; set; }
        public int CARIID { get; set; }
        public DateTime CIKISTARIH { get; set; }
        public DateTime VADETARIH { get; set; }
        public DateTime ODEMETARIH { get; set; }
        public decimal TUTAR { get; set; }
        public int DOVIZID { get; set; }
        public decimal KUR { get; set; }
        public decimal DOVIZTUTAR { get; set; }
        public int BANKA { get; set; }
        public int SUBE { get; set; }
        public int HESAPNO { get; set; }
        public int SERINO { get; set; }
        public int IBANNO { get; set; }
        public int MUHASEBEID { get; set; }
        public int ISLEM { get; set; }
        public int DURUM { get; set; }
        public int ACIKLAMA1 { get; set; }
        public int ACIKLAMA2 { get; set; }
        public int AKTIF { get; set; }
        public int BANKAID { get; set; }
        public int SONUSTID { get; set; }
        public int ISLEMTIPI { get; set; }
    }
}
