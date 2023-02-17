using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPSOFOR : SUPERMODEL
    {
        public string TC { get; set; }
        [StringLength(100)]
        public string ADI { get; set; }
        [StringLength(100)]
        public string SOYADI { get; set; }
        [StringLength(200)]
        public string TELEFON { get; set; }
        public string CEPNO { get; set; }
        public DateTime ISBASTAR { get; set; }
        public DateTime ISBITTAR { get; set; }
    }
}
