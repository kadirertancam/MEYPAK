using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CARI
{
    public class PocoSEVKADRES:SUPERPOCOMODEL
    {
       
        public int althesapid { get; set; }
        public string kodu { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle { get; set; }
        public string sokak { get; set; }
        public string apartman { get; set; }
        public string daire { get; set; }
    }
}
