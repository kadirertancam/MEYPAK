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
        public int NUM { get; set; }                //Sıra numarası
        public decimal KATSAYI { get; set; }
        public int KULLANICIID { get; set; }
        public int STOKID { get; set; } 
        public virtual PocoSTOK MPSTOK { get; set; }
        public int OLCUBRID { get; set; }
        public virtual PocoOLCUBR MPOLCUBR { get; set; }

    }
}
