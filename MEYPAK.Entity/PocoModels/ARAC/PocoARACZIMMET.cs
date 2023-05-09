using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.ARAC
{
    public class PocoARACZIMMET:SUPERPOCOMODEL
    {
        public int aracid { get; set; }
        public DateTime zimmettarihi { get; set; }
        public DateTime teslimtarihi { get; set; }
        public string markamodel { get; set; }
        public string serino { get; set; }
        public int miktar { get; set; }
        public string aciklama { get; set; }
        public bool teslimalindi { get; set; }
    }
}
