using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PERSONEL
{
    public class MPPERSONELBANKA:SUPERMODEL
    {
        public int PERSONELID { get; set; }
        public string BANKAADI { get; set; }
        public string BANKASUBEKODU { get; set; }
        public string BANKASUBEADI { get; set; }
        public string IBANNO { get; set; }
    }
}
