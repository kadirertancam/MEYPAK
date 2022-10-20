using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARACLAR
    {
        [Key]
        public int ID { get; set; }
        public DateTime OLUTURMATARIHI { get; set; }
        public DateTime GUNCELLEMETARIHI { get; set; }
        public int SIRKETID { get; set; }
        public int SUBEID { get; set; }
        [StringLength(50)]
        [Required]
        public string PLAKA { get; set; } = "";
        [StringLength(50)]
        public string MARKA { get; set; } = "";
        [StringLength(50)]
        public string MODEL { get; set; } = "";

        public int YIL { get; set; }
        public int PERSONELID { get; set; }
        public int ARACKM { get; set; }
        [StringLength(500)]
        public string ACIKLAMA { get; set; } = "";

        public DateTime SERVISTAR { get; set; }
        public DateTime MUAYENETAR { get; set; }
        public byte KAYITTIPI { get; set; } = 0;


    }
}
