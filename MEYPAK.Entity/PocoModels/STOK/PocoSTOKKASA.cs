using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKKASA:SUPERPOCOMODEL
    {
        public int SIRKETID { get; set; }
        public int SUBEID { get; set; }
        [StringLength(100), Required]
        public string KASAKODU { get; set; }
        [StringLength(100)]
        public string KASAADI { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        public byte AKTIF { get; set; }
    }
}
