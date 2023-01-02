using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.BANKA
{
    public class PocoHESAPHAREKET:SUPERPOCOMODEL
    {
        public int HESAPID { get; set; }
        public byte IO { get; set; }
        public string ISLEMTURU { get; set; }
        public string ACIKLAMA { get; set; }
        public decimal MIKTAR { get; set; }
    }
}
