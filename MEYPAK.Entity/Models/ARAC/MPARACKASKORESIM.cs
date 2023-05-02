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
    public class MPARACKASKORESIM:SUPERMODEL
    {
        public int ARACID { get; set; }
        public string KASACENTEADI { get; set; }
        public string KASPOLICENO { get; set; }
        public DateTime KASBASTAR { get; set; }
        public DateTime KASBITTAR { get; set; }
        public int NUM { get; set; }
        public string DOSYATIP { get; set; }
        [MaxLength, Column(TypeName = "ntext")]
        public string IMG { get; set; }
    }
}
