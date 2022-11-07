using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKFIYATLISTHAR:SUPERPOCOMODEL
    {
        public int sirketid { get; set; }=0;
        public int subeid { get; set; } = 0;
        public int stokid { get; set; } = 0;
        public int fiyatlistid { get; set; }
        public int dovizid { get; set; } = 0;
        public double kur { get; set; } = 0;
        public double netfiyat { get; set; } = 0;
        public double iskonto { get; set; } = 0;
        public int kullaniciid { get; set; } = 0;
        public int aktif { get; set; } = 0;
        
    }
}
