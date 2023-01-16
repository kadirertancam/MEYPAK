using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoMusteriCekKalem
    {
        public int SIRANO { get; set; }
        public int ÇEKNO { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime VADETARIHI { get; set; }
        public string BANKAADI { get; set; }
        public string SUBEADI { get; set; }
        public string HESAPNO { get; set; }
        public string IBAN { get; set; }
        public decimal TUTAR { get; set; }
        public int DOVIZTIP { get; set; }
        public decimal KUR { get; set; }
        public bool ASIL { get; set; }
    }
}
