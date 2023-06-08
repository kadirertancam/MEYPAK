using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.DEPO
{
    public class MPDEPOCEKILIST:SUPERMODEL
    {

        public int ISEMRIID { get; set; }
        public int STOKID { get; set; }
        public int DEPOID { get; set; }
        public int BIRIMID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MIKTAR { get; set; }

    }
}
