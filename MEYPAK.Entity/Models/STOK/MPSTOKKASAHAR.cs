using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPKASAHAR : SUPERMODEL
    {
        public int STOKID { get; set; }
        public int KASAID { get; set; }
        public int IRSALIYEID { get; set; }
        public int FATURAID { get; set; }
        public int IO { get; set; }
        public decimal MIKTAR { get; set; }
        public string BELGE_NO { get; set; }
    }
}
