using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKKASA:SUPERMODEL
    {
        
        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; }=0;
        public int MARKAID { get; set; }
        [StringLength(100)]
        public string KASAKODU { get; set; } = "";
        [StringLength(100)]
        public string KASAADI { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        public byte AKTIF { get; set; }
      
    }
}
