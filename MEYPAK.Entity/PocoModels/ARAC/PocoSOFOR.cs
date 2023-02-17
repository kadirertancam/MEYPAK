using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.ARAC
{
    public  class PocoSOFOR : SUPERPOCOMODEL
    {
        public string tc { get; set; }
        [StringLength(100)]
        public string adi { get; set; }
        [StringLength(100)]
        public string soyadi { get; set; }
        [StringLength(200)]
        public string telefon { get; set; }
        public string cepno { get; set; }
        public DateTime isbastar { get; set; }
        public DateTime isbittar { get; set; }
    }
}
