using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPO : SUPERPOCOMODEL
    {
        public int sirketid { get; set; }
        public string depokodu { get; set; }
        public string depoadi { get; set; }
        public string aciklama { get; set; }
        public int aktif { get; set; }
    }
}
