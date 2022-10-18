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
    public class MPSTOKFIYATLISTHAR
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int SIRKETID { get; set; }
        public int SUBEID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }
        public DateTime GUNCELLEMETARIHI { get; set; }
        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }

        [ForeignKey("MPSTOKFIYATLIST")]
        public int FIYATLISTID { get; set; }
        public int DOVIZID { get; set; }
        public decimal KUR { get; set; }
        public decimal NETFIYAT { get; set; }
        public decimal ISKONTO { get; set; }
        public int KULLANICIID { get; set; }

        public int AKTIF { get; set; }
        public byte KAYITTIPI { get; set; } = 0;
        [JsonIgnore]
        public virtual MPSTOK MPSTOK { get; set; }
        
        [JsonIgnore]
        public virtual MPSTOKFIYATLIST MPSTOKFIYATLIST { get; set; } 
    }
}
