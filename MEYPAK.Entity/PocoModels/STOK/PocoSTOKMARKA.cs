using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKMARKA
    {
        public int ID { get; set; }
        [StringLength(100)]
        [Required]
        public string ADI { get; set; }
        [StringLength(200)]
        public string ACIKLAMA { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }
        public DateTime GUNCELLEMETARIHI { get; set; }
        public byte KAYITTIPI { get; set; } = 0;
    }
}
