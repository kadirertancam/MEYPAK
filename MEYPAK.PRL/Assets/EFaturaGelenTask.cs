using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class EFaturaGelenTask
    {
        public bool SEC { get; set; }
        public string ID { get; set; }
        public string CARISEC { get; set; }
        public string FATURALASTIR { get; set; }
        public string BASIM { get; set; }
        public string VKNTCK { get; set; }
        public string CARIADI { get; set; }
        public string BELGENO { get; set; }
        public DateTime? TARIH { get; set; }
        public DateTime? VADETARIHI { get; set; }
        public decimal TUTAR { get; set; }
        public decimal KDV { get; set; }
        public string FATURATIP { get; set; }
        public bool ARSIVLENMIS { get; set; }
        public string TIP { get; set; }
        public string ETTNO { get; set; }
        public string DURUM { get; set; }

    }
}
