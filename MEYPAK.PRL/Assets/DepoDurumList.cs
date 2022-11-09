using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class DepoDurumList
    {
        public string StokKodu { get; set; }
        public string StokAdı { get; set; }
        public string DepoAdı { get; set; }
        public decimal Miktar { get; set; }
        public decimal BekleyenMiktar { get; set; }
    }
}
