using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPDEPOTRANSFERBILGI
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int ID { get; set; }
        [Column(Order = 2)]
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        [Column(Order = 3)]
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        [Column(Order = 3)]
        [Required]
        public int DEPOTRANSFERID { get; set; }
        [Column(Order = 4)]
        [Required]
        public int STOKID { get; set; }
        [Column(Order = 5)]
        public int MIKTAR { get; set; }

        [Column(Order = 6)]
        public int DURUM { get; set; }
        [Required]
        [Column(Order =7)]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");

        [ForeignKey("DEPOTRANSFERID")]
        public virtual MPDEPOTRANSFER DEPOTRANSFER { get; set; }
        [ForeignKey("STOKID")]
        public virtual MPSTOK STOK { get; set; }

    }
}
