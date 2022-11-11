using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PERSONEL
{
    public class PocoPERSONELZIMMET:SUPERPOCOMODEL
    {
        public int personelid { get; set; }
        public DateTime zimmettarihi { get; set; }
        public DateTime teslimtarihi { get; set; }
        public string markamodel { get; set; }
        public string serino { get; set; }
        public int miktar { get; set; }
        public string aciklama { get; set; }
    }
}
