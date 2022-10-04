using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace MEYPAK.Entity.PocoModels
{
    public class PocoStokSayimPanelList
    {
        public string StokKodu { get; set; } 
        public string StokAdı { get; set; }
        public int Birim { get; set; }
        public decimal Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public virtual MPSTOKSAYIMHAR MPSTOKSAYIMHAR{get; set;}

    }
}
