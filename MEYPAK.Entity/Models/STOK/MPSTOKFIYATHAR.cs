using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKFIYATHAR:SUPERMODEL
    {
        public int FIRMAID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int STOKFIYATID { get; set; }
        public int STOKID { get; set; }
        public int PARABIRIMID { get; set; } = 1;
        public decimal KUR { get; set; } = 1;
        public decimal FIYAT { get; set; }
        public int BIRIMID { get; set; }

    }
}
