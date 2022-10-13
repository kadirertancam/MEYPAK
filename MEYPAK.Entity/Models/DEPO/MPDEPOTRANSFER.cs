using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPDEPOTRANSFER
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        [Required]
        public int CIKTIDEPOID { get; set; }
        [Required]
        public int HEDEFDEPOID { get; set; }
        public byte DURUM { get; set; } = 0;
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");

        public byte KAYITTIPI { get; set; } = 0;

    }
}
