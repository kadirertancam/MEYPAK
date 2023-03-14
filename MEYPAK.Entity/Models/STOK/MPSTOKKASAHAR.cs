using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKKASAHAR : SUPERMODEL
    {
        public int STOKID { get; set; }
        public int KASAID { get; set; }
        public int DEPOID { get; set; }
        public int IRSALIYEID { get; set; } 
        public int IRSALIYEDETAYID { get; set; }
        public int CARIID { get; set; }
        public int MUSTAHSILCARIID { get; set; }
        public int FATURAID { get; set; }
        public int FATURADETAYID { get; set; }
        public int MUSTAHSILID { get; set; }
        public int MUSTAHSILDETAYID { get; set; }
        public int SARFID { get; set; }
        public int SARFDETAYID { get; set; }
        public int IO { get; set; }
        public decimal MIKTAR { get; set; }
        public string BELGE_NO { get; set; }
    }
}
