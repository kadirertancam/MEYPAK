using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPDEPO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public int SIRKETID { get; set; }
        [StringLength(100)]
        [Required]
        public string DEPOKODU { get; set; }
        [StringLength(100)]
        public string DEPOADI { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        public byte KAYITTIPI { get; set; } = 0;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPDEPOEMIR> MPDEPOEMIR { get; set; }




    }
}
