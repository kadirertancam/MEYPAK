using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.Entity.Models.SIPARIS
{
    public class MPSIPARISSEVKEMRIHAR:SUPERMODEL
    { 
        public DateTime TARIH { get; set; }
        public int TIP { get; set; }
        public int KULLANICIID { get; set; }
        public int EMIRID { get; set; }
        public int SIPARISID { get; set; }
        public int SIPARISKALEMID { get; set; }
        public decimal SIPARISMIKTARI { get; set; }
        public decimal EMIRMIKTARI { get; set; }

    }
}
