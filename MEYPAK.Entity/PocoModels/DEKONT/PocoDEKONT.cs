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
        public string belgeno { get; set; }
        public int althesapid { get; set; }
        public decimal borc { get; set; }
        public decimal alacak { get; set; }
        public decimal kdv { get; set; }
        public bool kdvdahiledilsin { get; set; }
        public int depo { get; set; }
    }
}
