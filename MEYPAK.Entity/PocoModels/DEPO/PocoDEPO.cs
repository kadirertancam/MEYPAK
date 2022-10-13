using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPO
    {
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
    }
}
