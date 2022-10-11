using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPSTOKSEVKİYATLİST
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int SIRKETID { get; set; }=0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; } = 0;
        public int STOKID { get; set; }
        public int BIRIMID { get; set; }
        public decimal SIPARISMIKTARI { get; set; }
        public decimal MIKTAR { get; set; }
        public int EMIRID { get; set; }
        public int KULLANICIID { get; set; } = 0;
    }
}
