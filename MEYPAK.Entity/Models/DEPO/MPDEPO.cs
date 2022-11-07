using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPDEPO:SUPERMODEL
    {

        public int SIRKETID { get; set; }
        [StringLength(100)]
        [Required]
        public string DEPOKODU { get; set; }
        [StringLength(100)]
        public string DEPOADI { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";



    }
}
