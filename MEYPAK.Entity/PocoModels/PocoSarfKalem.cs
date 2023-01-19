using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoSarfKalem
    {
        public int id { get; set; }
        public string STOK { get; set; }
        public int STOKID { get; set; }
        public int KASAID { get; set; }
        public int BIRIMID { get; set; }
        public string BIRIM { get; set; }
        public string ACIKLAMA { get; set; } = "";
        public decimal MIKTAR { get; set; } = 0;
        public string KUNYE { get; set; } = "";
        public string TIP { get; set; } //0-STOK-1 KASA
    }
}
