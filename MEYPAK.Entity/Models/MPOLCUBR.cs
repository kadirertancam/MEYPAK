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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }= DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; }=DateTime.Now;
        public string ADI { get; set; } = "";
        public string BIRIM { get; set; } = "";
        public int KAYITTIPI { get; set; } = 0;
        public int KULLANICIID { get; set; } = 0;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKOLCUBR> MPSTOKOLCUBR { get; set; }
      
    }
}
