using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPSTOKFIYATLIST
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }
        public DateTime GUNCELLEMETARIHI { get; set; }
        public int STOKID { get; set; }
        public int NUM { get; set; }
        public decimal NETFIYAT { get; set; }
        public decimal ISKONTO { get; set; }
        public int KULLANICIID { get; set; }
        public int KAYITTIPI { get; set; }
        public int AKTIF { get; set; }

    }
}
