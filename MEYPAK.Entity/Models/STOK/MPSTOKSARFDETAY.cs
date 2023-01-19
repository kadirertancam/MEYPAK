using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKSARFDETAY:SUPERMODEL
    {
        public int SARFID { get; set; }
        public int STOKID { get; set; }
        public int KASAID { get; set; }
        public int BIRIMID { get; set; }
        public string ACIKLAMA { get; set; } = "";
        public decimal MIKTAR { get; set; } = 0;
        public string KUNYE { get; set; } = "";
        public int TIP { get; set; }
    }
}
