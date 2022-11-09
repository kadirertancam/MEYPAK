using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CARI
{ 
    public class PocoCARIALTHES:SUPERPOCOMODEL
    {
        public string adi { get; set; }
        public string kod { get; set; }
        public int dovizid { get; set; }
        public byte aktif { get; set; }

    }
}
