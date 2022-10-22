using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKMARKA:SUPERMODEL
    {

        [StringLength(100)]
        [Required]
        public string ADI { get; set; }
        [StringLength(200)]
        public string ACIKLAMA { get; set; }

    }
}
