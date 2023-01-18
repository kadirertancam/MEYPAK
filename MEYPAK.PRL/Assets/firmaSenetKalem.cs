using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class firmaSenetKalem
    {
        public int ID { get; set; }
        public int SIRA { get; set; }
        public string SENETNO { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime VADETARIHI { get; set; }
        public decimal TUTAR { get; set; }
        public int DOVIZCINSI { get; set; }
        public decimal DOVIZTUTAR { get; set; }
        public string ACIKLAMA1 { get; set; } = "";
        public string ACIKLAMA2 { get; set; } = "";

    }
}
