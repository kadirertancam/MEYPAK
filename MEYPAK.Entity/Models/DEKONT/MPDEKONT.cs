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
        public string BELGENO { get; set; }
        public int ALTHESAPID { get; set; }
        public decimal BORC { get; set; }
        public decimal ALACAK { get; set; }
        public decimal KDV { get; set; }
        public bool KDVDAHILEDILSIN { get; set; }
        public int DEPO { get; set; }


       
    }
}
