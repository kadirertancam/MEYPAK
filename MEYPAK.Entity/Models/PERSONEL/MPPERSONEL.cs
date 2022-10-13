using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PERSONEL
{
    public class MPPERSONEL
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int SIRKETID { get; set; }
        public int SUBEID { get; set; }
        [StringLength(11), Required]
        public string TC { get; set; }
        [StringLength(100)]
        public string ADI { get; set; }
        [StringLength(100)]
        public string SOYADI { get; set; }
        [StringLength(200)]
        public string ADISOYADI => $"{ADI} {SOYADI}";
        [StringLength(50)]
        public string SGKSICIL { get; set; }
        public DateTime DOGUMTAR { get; set; }
        public DateTime ISBASTAR { get; set; }
        public DateTime ISBITTAR { get; set; }

        public string RESIM { get; set; }
        [StringLength(50)]
        public string EHLIYETNO { get; set; }
        [StringLength(11)]
        public string TEL { get; set; }
        [StringLength(100)]
        public string EMAIL { get; set; }
        [StringLength(50)]
        public string KANGRUBU { get; set; }
        [StringLength(500)]
        public string ADRES { get; set; }
        [StringLength(100)]
        public string GOREVI { get; set; }
        [StringLength(100)]
        public string SCR { get; set; }
        public DateTime PSIKOTAR { get; set; }
        public int MEDENIDURUM { get; set; }
        [StringLength(50)]
        public string ASKERLIK { get; set; }

        public byte DURUM { get; set; } = 0;
        public int PSD { get; set; }
        public byte KAYITTIPI { get; set; } = 0;
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");
    }
}
