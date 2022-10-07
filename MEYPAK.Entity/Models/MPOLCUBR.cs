using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPOLCUBR
    {
        public MPOLCUBR()
        {
            MPSTOKSAYIMHAR = new HashSet<MPSTOKSAYIMHAR>();
            MPSTOKOLCUBR = new HashSet<MPSTOKOLCUBR>();
        }
        [Key]
        public int ID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }= DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; }=DateTime.Now;
        [StringLength(200)]
        public string ADI { get; set; } = "";
        [StringLength(50)]
        public string BIRIM { get; set; } = "";
        
        public int KULLANICIID { get; set; } = 0;
        public byte KAYITTIPI { get; set; } = 0;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKOLCUBR> MPSTOKOLCUBR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }

    }
}
