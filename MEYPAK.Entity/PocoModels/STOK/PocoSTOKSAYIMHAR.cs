using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKSAYIMHAR:SUPERPOCOMODEL
    {
        public int firmaid { get; set; } = 0;
        public int subeid { get; set; } 
        public int depoid { get; set; }
        public int stoksayimid { get; set; }
        public decimal miktar { get; set; }
        public decimal fiyat { get; set; }
        public int parabr { get; set; } = 1;
        public decimal kur { get; set; } = 1;
        public int stokid { get; set; }
        public int birimid { get; set; }
    }
}
