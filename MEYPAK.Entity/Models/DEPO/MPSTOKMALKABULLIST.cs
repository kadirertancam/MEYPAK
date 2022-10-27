using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using System.Text.Json.Serialization;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPSTOKMALKABULLIST:SUPERMODEL
    {

        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; } = 0;
        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }
        [ForeignKey("MPOLCUBR")]
        public int BIRIMID { get; set; }
        [ForeignKey("MPSIPARISDETAY")]
        public int SIPARISDETAYID { get; set; }
        [ForeignKey("MPSATINALMAMALKABULEMRIHAR")]
        public int SATINALMAMALKABULEMRIHARID { get; set; }
        public decimal SIPARISMIKTARI { get; set; }
        public decimal MIKTAR { get; set; }
        [ForeignKey("MPDEPOEMIR")]
        public int EMIRID { get; set; }
        public MPOLCUBR MPOLCUBR { get; set; } 
        public MPDEPOEMIR MPDEPOEMIR { get; set; } 
        public MPSTOK MPSTOK { get; set; } 
        public MPSIPARISDETAY MPSIPARISDETAY { get; set; }
        public MPSATINALMAMALKABULEMRIHAR MPSATINALMAMALKABULEMRIHAR { get; set; }
    }
}
