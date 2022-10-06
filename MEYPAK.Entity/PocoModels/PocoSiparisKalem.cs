using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoSiparisKalem
    {
        public string StokKodu { get; set; }
        public string StokAdı { get; set; }
        public string Acıklama { get; set; }
        public int Birim { get; set; }
        public int Miktar { get; set; }
        public int Doviz { get; set; }
        public int NetFiyat { get; set; }
        public int İskonto1 { get; set; }
        public int İskonto2 { get; set; }
        public int İskonto3 { get; set; }
        public int Kdv { get; set; }
        public int NetToplam { get; set; }
        public int BrütToplam { get; set; }
        public List<string> ListeFiyatı { get; set; }

         

    }
}
