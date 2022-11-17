using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    public class MPSEVKADRESI:SUPERMODEL
    {
        public int ALTHESAPID { get; set; }
        public string KODU { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string MAHALLE { get; set; }
        public string SOKAK { get; set; }
        public string APARTMAN { get; set; }
        public string DAIRE { get; set; }



    }
}
