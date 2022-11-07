using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using System.ComponentModel.DataAnnotations.Schema;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOEMIR:SUPERPOCOMODEL
    {
        public DateTime tarih { get; set; }=DateTime.Now;
        public int depoid { get; set; }=0;
        public int sira { get; set; } = 0;
        public int tip { get; set; } = 0;
        public int siparisid { get; set; } = 0;
        public int durum { get; set; } = 0;
        public decimal miktar { get; set; } = 0;
        public string aciklama { get; set; } = "";
    }
}
