using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOCEKILIST
    {
        public int ID { get; set; }
        public int ISEMRIID { get; set; }
        public int STOKID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }
        public DateTime GUNCELLEMETARIHI { get; set; }
        public int BIRIMID { get; set; }
        public int MIKTAR { get; set; }
        public int KAYITTIPI { get; set; }
    }
}
