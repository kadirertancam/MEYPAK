using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPDEPO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int ID { get; set; }
        [Column(Order = 2)]
        public DateTime OLUSTURMATARIHI { get; set; }= DateTime.Now;    
        [Column(Order = 3)]
        public DateTime GUNCELLEMETARIHI { get; set; }=DateTime.Now;    
        [Column(Order = 4)]
        public int SIRKETID { get; set; }
        [StringLength(100)]
        [Column(Order = 5)]
        [Required]
        public string DEPOKODU { get; set; }
        [Column(Order = 6)]
        [StringLength(100)]
        public string DEPOADI { get; set; } = ""; 
        [Column(Order = 7)]
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";

        public byte KAYITTIPI { get; set; }
        
    }
}
