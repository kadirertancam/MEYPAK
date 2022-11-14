using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.KASA
{
    public class MPKASA:SUPERMODEL
    {
        public int PARABIRIMID { get; set; }
        public string ADI { get; set; }
        public string ACIKLAMA { get; set; }
        public DateTime TARIH { get; set; }
        public decimal TUTAR { get; set; }
        public byte DURUM { get; set; }
    }
}
