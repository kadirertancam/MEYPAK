using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOTRANSFER:SUPERPOCOMODEL
    {
        [Required]
        public int ciktidepoid { get; set; }
        [Required]
        public int hedefdepoid { get; set; }
        public byte durum { get; set; } = 0;
        [Required]
        public string donem { get; set; } = DateTime.Now.ToString("yyyy");
    }
}
