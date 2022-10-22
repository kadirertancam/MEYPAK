using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKMARKA : SUPERPOCOMODEL
    {
        [StringLength(100)]
        [Required]
        public string ADI { get; set; }
        [StringLength(200)]
        public string ACIKLAMA { get; set; }

    }
}
