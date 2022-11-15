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
        public string sigacenteadi { get; set; }
        public string sigpoliceno { get; set; }
        public DateTime sigbastar { get; set; }
        public DateTime sigbittar { get; set; }
        public string kasacenteadi { get; set; }
        public string kaspoliceno { get; set; }
        public DateTime kasbastar { get; set; }
        public DateTime kasbittar { get; set; }
        public DateTime muayenebastar { get; set; }
        public DateTime muayenebittar { get; set; }
        public DateTime egzozbastar { get; set; }
        public DateTime egzozbittar { get; set; }
    }
}
