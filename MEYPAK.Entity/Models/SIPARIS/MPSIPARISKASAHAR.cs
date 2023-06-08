using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.SIPARIS
{
    public class MPSIPARISKASAHAR:SUPERMODEL
    {
        public int KASAID { get; set; }
        public int SIPARISDETAYID { get; set; }
        public int SIPARISID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MIKTAR { get; set; }

    }
}
