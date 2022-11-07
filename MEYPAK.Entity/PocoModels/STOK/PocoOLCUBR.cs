using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.DEPO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoOLCUBR:SUPERPOCOMODEL
    {
        [StringLength(200)]
        public string adi { get; set; } = "";
        [StringLength(50)]
        public string birim { get; set; } = "";
        public int kullaniciid { get; set; } = 0;

    }
}
