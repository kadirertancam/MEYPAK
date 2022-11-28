using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoIrsaliyeKalem
    {
        
        public int StokId { get; set; }
        public string StokKodu { get; set; }
        public int sıra { get; set; }
        public string StokAdı { get; set; } = "";
        public string Tipi { get; set; } = "STOK";
        public int KasaId { get; set; }
        public string KasaAdı { get; set; } = "";
        public string Acıklama { get; set; } = "";
        public string Birim { get; set; } = "";
        public string Kunye { get; set; }
        public decimal Miktar { get; set; } = 0;
        public decimal Daralı { get; set; }
        public decimal Dara { get; set; }
        public decimal Safi { get; set; }
        public string Doviz { get; set; } = "";
        public decimal BirimFiyat { get; set; } = 0;
        public decimal NetFiyat { get; set; } = 0;
        public decimal BrütFiyat { get; set; } = 0;
        public decimal İskonto1 { get; set; } = 0;
        public decimal İskonto2 { get; set; } = 0;
        public decimal İskonto3 { get; set; } = 0;
        public decimal Kdv { get; set; } = 0;
        public decimal KdvTutarı { get; set; }
        public decimal İskontoTutarı { get; set; }
        public decimal NetToplam { get; set; } = 0;
        public decimal BrütToplam { get; set; } = 0;
    }
}
