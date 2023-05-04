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
    public class MPARACSIGORTARESIM:SUPERMODEL
    {
        public int ARACID { get; set; }
        public string SIGACENTEADI { get; set; }
        public string SIGPOLICENO { get; set; }
        public DateTime SIGBASTAR { get; set; }
        public DateTime SIGBITTAR { get; set; }
        public int NUM { get; set; }
        public string DOSYATIP { get; set; }

        [MaxLength, Column(TypeName = "ntext")]
        public string IMG { get; set; }
    }
}
