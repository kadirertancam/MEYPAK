using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOEMIR
    {
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        public int SIRA { get; set; }
        public int TIP { get; set; }
        public int SIPARISID { get; set; }
        public int DURUM { get; set; }
        public decimal MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public MPSIPARIS MPSIPARIS { get; set; }
    }
}
