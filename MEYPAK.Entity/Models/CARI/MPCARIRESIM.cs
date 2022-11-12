using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    public class MPCARIRESIM:SUPERMODEL
    {
        public int CARIID { get; set; }
        public int NUM { get; set; }
        [MaxLength, Column(TypeName = "ntext")]
        public string IMG { get; set; }
    }
}
