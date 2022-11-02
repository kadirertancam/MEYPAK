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
        public int sirketid { get; set; }
        public int subeid { get; set; }
        public int stokid { get; set; }
        public int fiyatlistid { get; set; }
        public int dovizid { get; set; }
        public double kur { get; set; }
        public double netfiyat { get; set; }
        public double iskonto { get; set; }
        public int kullaniciid { get; set; }
        public int aktif { get; set; }
        public virtual PocoSTOK mpstok { get; set; }
        public virtual PocoSTOKFIYATLIST mpstokfiyatlist { get; set; }
        
    }
}
