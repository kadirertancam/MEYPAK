using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    internal class PocoSTOKFIYAT :SUPERPOCOMODEL
    {
        public int firmaid { get; set; } = 0;
        public int subeid { get; set; } = 0;
        public int cariid { get; set; }
        public string adi { get; set; } = "";
        public DateTime baslangictarihi { get; set; }
        public DateTime bitistarihi { get; set; }
        public string aciklama { get; set; }
        public int aktif { get; set; } = 1;
    }
}
