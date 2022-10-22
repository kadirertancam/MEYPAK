using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKSAYIM:SUPERMODEL
    {
        public MPSTOKSAYIM()
        {
       //     MPSTOKSAYIMHAR = new HashSet<MPSTOKSAYIMHAR>();
        }
        public int FIRMAID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; }
        public DateTime SAYIMTARIHI { get; set; }
        [StringLength(500)]
        public string ACIKLAMA { get; set; }
        public int DURUM { get; set; }  // işlendi 1 işlenmedi 0
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
    }
}
