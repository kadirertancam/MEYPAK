using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARAC:SUPERMODEL
    {
        public string PLAKA { get; set; }
        public string TIP { get; set; }
        public string MARKA { get; set; }
        public string MODEL { get; set; }
        public string YAKITTURU { get; set; }
        public int SOFORID { get; set; }
        public int SOFOR2ID { get; set; }
        public string SIGACENTEADI { get; set; }
        public string SIGPOLICENO { get; set; }
        public DateTime SIGBASTAR { get; set; }
        public DateTime SIGBITTAR { get; set; }
        public string KASACENTEADI { get; set; }
        public string KASPOLICENO { get; set; }
        public DateTime KASBASTAR { get; set; }
        public DateTime KASBITTAR { get; set; }
        public DateTime MUAYENEBASTAR { get; set; }
        public DateTime MUAYENEBITTAR { get; set; }
        public DateTime EGZOZBASTAR { get; set; }
        public DateTime EGZOZBITTAR { get; set; }
    }
}
