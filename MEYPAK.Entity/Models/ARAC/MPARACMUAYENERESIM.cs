using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARACMUAYENERESIM:SUPERMODEL
    {
        public int ARACID { get; set; }
        public DateTime MUAYENEBASTAR { get; set; }
        public DateTime MUAYENEBITTAR { get; set; }
        public DateTime EGZOZBASTAR { get; set; }
        public DateTime EGZOZBITTAR { get; set; }
        public int NUM { get; set; }
        public string DOSYATIP { get; set; }

        [MaxLength, Column(TypeName = "ntext")]
        public string IMG { get; set; }
    }
}
