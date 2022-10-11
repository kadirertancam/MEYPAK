using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoStokSevkiyatList
    {
        public int ID { get; set; }
        public string StokKodu { get; set; }
        public string StokAdı { get; set; }
        public string Birim { get; set; }
        public decimal Miktar { get; set; }
        public virtual MPSTOK MPSTOK { get; set; } 
    }
}
