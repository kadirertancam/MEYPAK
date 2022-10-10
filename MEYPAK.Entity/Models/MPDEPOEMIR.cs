using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPDEPOEMIR
    {
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        public int SIRA { get; set; }
        public int TIP { get; set; }
        [ForeignKey("MPSIPARIS")]
        public int SIPARISID { get; set; }
        public int DURUM { get; set; }
        public decimal MIKTAR { get; set; } 
        public string ACIKLAMA { get; set; }
        public MPSIPARIS MPSIPARIS { get; set; }
    }
}
