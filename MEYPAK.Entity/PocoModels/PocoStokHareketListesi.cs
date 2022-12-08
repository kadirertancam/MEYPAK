using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoStokHareketListesi
    {
        
        public int ID { get; set; }
        public int STOKID { get; set; }
        public DateTime Tarih { get; set; }
        public string BelgeNo { get; set; }
        public string Acıklama { get; set; }
        public string HareketTuru { get; set; }
        public decimal Giris { get; set; }
        public decimal Cikis { get; set; }
        public string ParaBirimi { get; set; }
        public string Birim { get; set; } 
        public decimal NetFiyat { get; set; }
        public decimal NetToplam { get; set; }
        public decimal BrutToplam { get; set; }
        public string Depo { get; set; }

    }
}
