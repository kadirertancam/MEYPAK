using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARACMODEL:SUPERMODEL
    {
        [StringLength(30)]
        public string MARKAADI { get; set; }
        [StringLength(70)]
        public string MODELADI { get; set; }
    }
}
