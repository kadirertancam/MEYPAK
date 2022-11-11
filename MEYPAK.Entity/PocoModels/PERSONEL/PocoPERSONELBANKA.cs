using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PERSONEL
{
    public class PocoPERSONELBANKA:SUPERPOCOMODEL
    {
        public int personelid { get; set; }
        public string bankaadi { get; set; }
        public string bankasubekodu { get; set; }
        public string bankasubeadi { get; set; }
        public string ibanno { get; set; }
    }
}
