using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.SIPARIS;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPDEPOEMIR:SUPERMODEL
    {

        public DateTime TARIH { get; set; }
        public int SIRA { get; set; }
        public int DEPOID { get; set; }
        public int TIP { get; set; }
        public int SIPARISID { get; set; }
        public int DURUM { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }

    }
}
