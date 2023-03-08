using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.EISLEMLER
{
    internal class PocoGIDENIRSALIYELER:SUPERPOCOMODEL
    {
        public DateTime tarih { get; set; }
        public int irsaliyeid { get; set; }
        public string belgeno { get; set; }
        public int tip { get; set; }
        public string hatakodu { get; set; }
        public int durum { get; set; }
        public string ettno { get; set; }
    }
}
