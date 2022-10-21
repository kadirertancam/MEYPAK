using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC.Mobiliz
{
    public class MPARACLAR
    {
        public string PLAKA { get; set; }
        public string ETIKET { get; set; }
        public int SONSURUCUID { get; set; }
        public string BIRIMTIPI { get; set; }
        public string AGKIMLIGI { get; set; }
        public int DONANIMVERS { get; set; }
        public int YAZILIMVERS { get; set; }
        public string YAZILIMALTVERS { get; set; }
        public string GSM { get; set; }
        public string OPERATOR { get; set; }
        public DateTime AKTIVASYONTAR { get; set; }
        public int ARACTIPID { get; set; }
        public int ARACALTTIPID { get; set; }
        public int ARACMARKAID { get; set; }
        public int ARACMODELID { get; set; }
        public int YIL { get; set; }
        public decimal ARACMOTORHACMI { get; set; }
        public int AKARYAKITID { get; set; } 
    }
}
