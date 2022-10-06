using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Birim { get; set; }
        public decimal Miktar { get; set; }
        public string Doviz { get; set; }
        public decimal NetFiyat { get; set; }
        public decimal İskonto1 { get; set; }
        public decimal İskonto2 { get; set; }
        public decimal İskonto3 { get; set; }
        public decimal Kdv { get; set; }
        public decimal NetToplam { get; set; }
        public decimal BrütToplam { get; set; }
        public List<string> ListeFiyatı { get; set; }
        private List<MPSTOK> _MPSTOK = new List<MPSTOK>();
        public virtual List<MPSTOK> MPSTOK {
            get { return _MPSTOK.Where(x=>x.KOD==StokKodu).ToList(); }
           
        }



    }
}
