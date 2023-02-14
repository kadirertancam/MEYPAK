using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PERSONEL
{
    public class PocoPERSONELPARAMETRE:SUPERPOCOMODEL
    {
        public int AVANSKATI { get; set; }
        public bool AVANSKATIrequired { get; set; }

        public int AVANSMIKTAR { get; set; }
        public bool AVANSMIKTARrequired { get; set; }
    }
}
