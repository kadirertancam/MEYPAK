using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.ARAC
{
    public class PocoARACKASKORESIM:SUPERPOCOMODEL
    {
        public int aracid { get; set; }
        public string kasacenteadi { get; set; }
        public string kaspoliceno { get; set; }
        public DateTime kasbastar { get; set; }
        public DateTime kasbittar { get; set; }
        public int num { get; set; }
        public string dosyatip { get; set; }
        [MaxLength, Column(TypeName = "ntext")]
        public string img { get; set; }
    }
}
