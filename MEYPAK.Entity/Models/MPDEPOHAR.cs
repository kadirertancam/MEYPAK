using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPDEPOHAR
    {
        [Key]
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        
        public int SIPARISID { get; set; }
        public int SIPARISKALEMID { get; set; }
        public int GSUBEID { get; set; }
        public int GDEPOID { get; set; }
        public int CSUBEID { get; set; }
        public int CDEPOID { get; set; }
        public string STOKKODU { get; set; }
        public decimal SIPARISMIKTARI { get; set; }
        public decimal MIKTAR { get; set; }
        public int BIRIM { get; set; }
        public int STOKHARID { get; set; }
        public int EMIRID { get; set; }
        public int EMIRMIKTAR { get; set; }
        public int GSUBEKODU { get; set; }
        public int GDEPOKODU { get; set; }
        public int TRANSFERHARID { get; set; }
    }
}
