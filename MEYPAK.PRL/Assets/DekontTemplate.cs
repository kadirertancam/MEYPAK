using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class DekontTemplate
    {
        public string TIP { get; set; }
        public string KOD { get; set; }
        public string ALTHESAP { get; set; }
        public string BELGENO { get; set; } 
        public decimal BORC { get; set; }
        public decimal ALACAK { get; set; }
        public int KDV { get; set; }
        public bool  KDVDAHILEDILSIN { get; set; } 
        public string  DEPO { get; set; } 
    }
}
