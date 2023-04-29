using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class FaturaDetailList
    {
        public int SIRA { get; set; }
        public string KOD { get; set; }
        public string ADI { get; set; }
        public decimal MIKTAR { get; set; }
        public string KUNYENO { get; set; }
        public string BIRIM { get; set; }
        public decimal NETFIYAT { get; set; }
        public decimal TUTAR { get; set; } 
    }
}
