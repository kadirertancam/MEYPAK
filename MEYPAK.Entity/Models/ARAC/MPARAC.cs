using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARAC : SUPERMODEL
    {
        public string PLAKA { get; set; }
        public string TIP { get; set; }
        public string MARKA { get; set; }
        public string MODEL { get; set; }
        public string YAKITTURU { get; set; }
        public int SOFORID { get; set; }
        public int SOFOR2ID { get; set; }
        public byte TEKERSAYISI { get; set; }
        public byte YEDEKTEKERSAYISI { get; set; }
        public byte DURUM { get; set; }

    }
}
