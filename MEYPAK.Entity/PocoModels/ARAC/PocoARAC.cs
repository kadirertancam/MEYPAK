using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.ARAC
{
    public class PocoARAC:SUPERPOCOMODEL
    {
        public string plaka { get; set; }
        public string tip { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string yakitturu { get; set; }
        public int soforid { get; set; }
        public int sofor2id { get; set; }
        public byte tekersayisi { get; set; }
        public byte yedektekersayisi { get; set; }
        public byte durum { get; set; }
    }
}
