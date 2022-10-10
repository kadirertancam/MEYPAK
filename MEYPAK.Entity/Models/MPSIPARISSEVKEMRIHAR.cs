using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPSIPARISSEVKEMRIHAR
    {
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        public int KULLANICIID { get; set; }
        public int EMIRID { get; set; }
        public int SIPARISID { get; set; }
        public int SIPARISKALEMID { get; set; } 
        public decimal DEPOMIKTAR { get; set; }
        public decimal BEKLEYENMIKTAR { get; set; }
        public decimal SIPARISMIKTARI { get; set; }
        public decimal EMIRMIKTARI { get; set; }
    }
}
