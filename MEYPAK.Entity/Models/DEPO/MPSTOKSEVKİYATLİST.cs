using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPSTOKSEVKİYATLİST:SUPERMODEL
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
        public decimal SIPARISMIKTARI { get; set; }

        public decimal MIKTAR { get; set; }
        [ForeignKey("MPDEPOEMIR")]
        public int EMIRID { get; set; }
        public int KULLANICIID { get; set; } = 0;
        [ForeignKey("MPSIPARISSEVKEMRIHAR")]
        public int SEVKEMRIHARID { get; set; } 
        public virtual MPOLCUBR MPOLCUBR { get; set; } 
        public virtual MPDEPOEMIR MPDEPOEMIR { get; set; } 
        public virtual MPSTOK MPSTOK { get; set; } 
        public virtual MPSIPARISDETAY MPSIPARISDETAY { get; set; }
        public virtual MPSIPARISSEVKEMRIHAR MPSIPARISSEVKEMRIHAR { get; set; }
    }
}
