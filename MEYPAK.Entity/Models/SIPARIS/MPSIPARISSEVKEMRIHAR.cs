using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.Entity.Models.SIPARIS
{
    public class MPSIPARISSEVKEMRIHAR:SUPERMODEL
    {

        public DateTime TARIH { get; set; }
        public int TIP { get; set; }
        public int KULLANICIID { get; set; }
        [ForeignKey("MPDEPOEMIR")] 
        public int EMIRID { get; set; }
        [ForeignKey("MPSIPARIS")]
        public int SIPARISID { get; set; }
        [ForeignKey("MPSIPARISDETAY")]
        public int SIPARISKALEMID { get; set; }
        public decimal SIPARISMIKTARI { get; set; }
        public decimal EMIRMIKTARI { get; set; }
        public MPSIPARIS MPSIPARIS { get; set; }
        public MPSIPARISDETAY MPSIPARISDETAY { get; set; }
        public MPDEPOEMIR MPDEPOEMIR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKSEVKİYATLİST> MPSTOKSEVKİYATLİST { get; set; }

    }
}
