using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CARI
{
    public class PocoCARIYETKILI:SUPERPOCOMODEL
    {
        public int cariid { get; set; }
        public string adi { get; set; }
        public string pozisyon { get; set; }
        public string yetkilitelefon { get; set; }
    }
}
