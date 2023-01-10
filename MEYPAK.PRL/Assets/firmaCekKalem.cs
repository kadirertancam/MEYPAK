using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class firmaCekKalem
    {
        public int SIRA { get; set; }
        public string CEKNO { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime VADETARIHI { get; set; }
        public decimal TUTAR { get; set; }
        public int DOVIZCINSI { get; set; }
        public decimal DOVIZTUTAR { get; set; }
        public string ACIKLAMA1 { get; set; }
        public string ACIKLAMA2 { get; set; }
        public string BANKA { get; set; }
        public string SUBE { get; set; }
        public string HESAPNO { get; set; }
        public string IBAN { get; set; }
    }
}
