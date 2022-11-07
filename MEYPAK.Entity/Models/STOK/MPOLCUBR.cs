using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.DEPO;
using System.Text.Json.Serialization;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPOLCUBR:SUPERMODEL
    {
        public MPOLCUBR()
        {
        }


        [StringLength(200)]
        public string ADI { get; set; } = "";
        [StringLength(50)]
        public string BIRIM { get; set; } = "";
        public int KULLANICIID { get; set; } = 0;

    }
}
