using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKKASAHAR : SUPERPOCOMODEL
    {
        public int stokid { get; set; }
        public int kasaid { get; set; }
        public int irsaliyeid { get; set; }
        public int cariid { get; set; }
        public int faturaid { get; set; }
        public int io { get; set; }
        public decimal miktar { get; set; }
        public string belge_no { get; set; }
    }
}
