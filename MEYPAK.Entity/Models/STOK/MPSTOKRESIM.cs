using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKRESIM:SUPERMODEL
    {
        public int STOKID { get; set; }
        public int NUM { get; set; }
        [MaxLength, Column(TypeName = "ntext")]
        public string IMG { get; set; }
    }
}
