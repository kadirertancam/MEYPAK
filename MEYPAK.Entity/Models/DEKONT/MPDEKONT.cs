using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.DEKONT
{
    public class MPDEKONT:SUPERMODEL
    { 
        public int CARIID { get; set; }
        public int BANKAID { get; set; }
        public int PERSONELID { get; set; }
        public int KASAID { get; set; }
        public int MUHASEBEID { get; set; } 
        public int BELGENO { get; set; }
        public int TUTAR { get; set; }
        public int IO { get; set; }
        public int KDV { get; set; }
        public int ISKONTO1 { get; set; }
        public int ISKONTO2 { get; set; }
        public int ISKONTO3 { get; set; }
    }
}
