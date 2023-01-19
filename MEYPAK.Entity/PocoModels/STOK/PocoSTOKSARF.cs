using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKSARF:SUPERPOCOMODEL
    {
        public string SARFNO { get; set; }
        public int DEPOID { get; set; }
        public DateTime TARIH { get; set; }
        public string ACIKLAMA { get; set; } = "";
    }
}
