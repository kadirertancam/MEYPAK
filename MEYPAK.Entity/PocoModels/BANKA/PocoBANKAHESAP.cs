using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.BANKA
{
    public class PocoBANKAHESAP:SUPERPOCOMODEL
    {
        public int BANKAID { get; set; }
        public int SUBEID { get; set; }
        public int PARABIRIMID { get; set; }
        public string KOD { get; set; }
        public string ADI { get; set; }
        public string NO { get; set; }
        public string IBAN { get; set; }
        public byte TIP { get; set; }
    }
}
