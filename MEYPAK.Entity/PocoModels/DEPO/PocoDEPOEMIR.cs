using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOEMIR:SUPERPOCOMODEL
    {
        public DateTime tarih { get; set; }
        public int depoid { get; set; }
        public int sira { get; set; }
        public int tip { get; set; }
        public int siparisid { get; set; }
        public int durum { get; set; }
        public decimal miktar { get; set; }
        public string aciklama { get; set; }
        public PocoSIPARIS mpsiparis { get; set; }
        public PocoSTOK mpstok { get; set; }
        public PocoDEPO mpdepo { get; set; }

        public virtual List<PocoSIPARISSEVKEMIRHAR> mpsiparissevkemrihar { get; set; }
        public virtual List<PocoSTOKSEVKIYATLIST> mpstoksevkiyatlist { get; set; }

        public virtual List<PocoSTOKMALKABULLIST> mpstokmalkabullist { get; set; }
    }
}
