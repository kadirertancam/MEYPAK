using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKOLCUBR:SUPERPOCOMODEL
    {
        public int num { get; set; } 
        public decimal katsayi { get; set; }
        public int kullaniciid { get; set; }
        public int stokid { get; set; } 
        public virtual PocoSTOK mpstok { get; set; }
        public int olcubrid { get; set; }
        public virtual PocoOLCUBR mpolcubr { get; set; }

    }
}
