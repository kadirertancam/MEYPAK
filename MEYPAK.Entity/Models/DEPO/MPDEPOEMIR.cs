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
        [ForeignKey("MPDEPO")]
        public int DEPOID { get; set; }
        public int TIP { get; set; }
        [ForeignKey("MPSIPARIS")]
        public int SIPARISID { get; set; }
        public int DURUM { get; set; }
        public decimal MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }

        public virtual MPSIPARIS MPSIPARIS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKSEVKİYATLİST> MPSTOKSEVKİYATLİST { get; set; }
        public ICollection<MPDEPOEMIRSIPARISKALEMILISKI> MPDEPOEMIRSIPARISKALEMILISKI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKMALKABULLIST> MPSTOKMALKABULLIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSIPARISSEVKEMRIHAR> MPSIPARISSEVKEMRIHAR { get; set; }
        public virtual MPDEPO MPDEPO { get; set; }
    }
}
