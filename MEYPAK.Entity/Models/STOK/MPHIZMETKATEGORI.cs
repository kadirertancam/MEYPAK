using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPHIZMETKATEGORI:SUPERMODEL
    {
        [DefaultValue(0)]
        public int USTID { get; set; }

        [StringLength(100), Required]
        public string ADI { get; set; }
    }
}
