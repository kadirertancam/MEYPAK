using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEKONT
{
    public class PocoDEKONT:SUPERPOCOMODEL
    {
        public int cariid { get; set; }
        public int bankaid { get; set; }
        public int personelid { get; set; }
        public int kasaid { get; set; }
        public int muhasebeid { get; set; }
        public int belgeno { get; set; }
        public int tutar { get; set; }
        public int io { get; set; }
        public int kdv { get; set; }
        public int iskonto1 { get; set; }
        public int iskonto2 { get; set; }
        public int iskonto3 { get; set; }
    }
}
