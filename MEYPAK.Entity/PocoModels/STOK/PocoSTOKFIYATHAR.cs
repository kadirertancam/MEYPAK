using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKFIYATHAR : SUPERPOCOMODEL
    {
        public int firmaid { get; set; } = 0;
        public int subeid { get; set; } = 0;
        public int stokfiyatid { get; set; }
        public int stokid { get; set; }
        public int parabirimid { get; set; }
        public decimal kur { get; set; } = 1;
        public decimal fiyat { get; set; }
        public int birimid { get; set; }

    }
}
