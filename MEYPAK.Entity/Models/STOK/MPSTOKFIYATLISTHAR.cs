using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKFIYATLISTHAR:SUPERMODEL
    {
        public int SIRKETID { get; set; }
        public int SUBEID { get; set; }
        public int DOVIZID { get; set; }
        public decimal KUR { get; set; }
        public decimal NETFIYAT { get; set; }
        public decimal ISKONTO { get; set; }
        public int KULLANICIID { get; set; } 
        public int AKTIF { get; set; }


        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }
        public virtual MPSTOK MPSTOK { get; set; }


        [ForeignKey("MPSTOKFIYATLIST")]
        public int FIYATLISTID { get; set; }
        public virtual MPSTOKFIYATLIST MPSTOKFIYATLIST { get; set; } 
    }
}
