using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPDEPOTRANSFER
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int ID { get; set; }
        [Column(Order = 2)]
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        [Column(Order = 3)]
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        [Required]
        [Column(Order = 4)]
        public int CIKTIDEPOID { get; set; }
        
        [Required]
        [Column(Order = 5)]
        public int HEDEFDEPOID { get; set; }
        [Column(Order = 6)]
        public int DURUM { get; set; } = 0;
        [Column(Order = 7)]
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");
        [ForeignKey("CIKTIDEPOID")]
        public virtual MPDEPO CIKTIDEPO { get; set; }

        [ForeignKey("HEDEFDEPOID")]
        public virtual MPDEPO HEDEFDEPO { get; set; }
    }
}
