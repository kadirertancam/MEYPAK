using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.DEPO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoOLCUBR:SUPERPOCOMODEL
    {
        [StringLength(200)]
        public string adi { get; set; } = "";
        [StringLength(50)]
        public string birim { get; set; } = "";
        public int kullaniciid { get; set; } = 0;
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PocoSTOKOLCUBR> MPSTOKOLCUBR { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PocoSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PocoSTOKSEVKIYATLIST> MPSTOKSEVKİYATLİST { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PocoSTOKMALKABULLIST> MPSTOKMALKABULLIST { get; set; }

    }
}
