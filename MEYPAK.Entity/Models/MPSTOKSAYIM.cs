using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPSTOKSAYIM
    {
        public MPSTOKSAYIM()
        {
            MPSTOKSAYIMHAR = new HashSet<MPSTOKSAYIMHAR>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 
        public int FIRMAID { get; set; }=0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }=DateTime.Now; 
        public DateTime GUNCELLEMETARIHI { get; set; }= DateTime.Now;
        public DateTime SAYIMTARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public int KAYITTIPI { get; set; } = 0;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
    }
}
