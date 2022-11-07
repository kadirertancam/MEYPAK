using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PERSONEL
{
    public class PocoPERSONEL:SUPERPOCOMODEL
    {
        public int sirketid { get; set; }
        public int subeid { get; set; }
        [StringLength(11), Required]
        public string tc { get; set; }
        [StringLength(100)]
        public string adi { get; set; }
        [StringLength(100)]
        public string soyadi { get; set; }
        [StringLength(200)]
        public string adisoyadi => $"{adi} {soyadi}";
        [StringLength(50)]
        public string sgksicil { get; set; }
        public DateTime dogumtar { get; set; }
        public DateTime isbastar { get; set; }
        public DateTime isbittar { get; set; }
        public string resim { get; set; }
        [StringLength(50)]
        public string ehliyetno { get; set; }
        [StringLength(11)]
        public string tel { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        [StringLength(50)]
        public string kangrubu { get; set; }
        [StringLength(500)]
        public string adres { get; set; }
        [StringLength(100)]
        public string gorevi { get; set; }
        [StringLength(100)]
        public string scr { get; set; }
        public DateTime psikotar { get; set; }
        public int medenidurum { get; set; }
        [StringLength(50)]
        public string askerlik { get; set; }
        public byte durum { get; set; } = 0;
        public int psd { get; set; }
        [Required]
        public string donem { get; set; } = DateTime.Now.ToString("yyyy");
    }
}
