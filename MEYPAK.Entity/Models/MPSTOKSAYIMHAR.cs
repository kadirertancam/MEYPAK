using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPSTOKSAYIMHAR
    {
        public MPSTOKSAYIMHAR()
        {
            
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int FIRMAID { get; set; } = 0;
        public int SUBEID { get; set; }=0;
        public int DEPOID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }=DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        [ForeignKey("MPSTOKSAYIM")]
        public int STOKSAYIMID { get; set; }
        public decimal MIKTAR { get; set; }
        public decimal FIYAT { get; set; }
        public int PARABR { get; set; } = 1;
        public decimal KUR { get; set; } = 1;
        public int KAYITTIPI { get; set; } = 0;  

        public virtual MPSTOKSAYIM MPSTOKSAYIM { get; set; }

        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }
        public virtual MPSTOK MPSTOK { get; set; }

        [ForeignKey("MPOLCUBR")]
        public int BIRIMID { get; set; }
        public virtual MPOLCUBR MPOLCUBR { get; set; }

    }
}
