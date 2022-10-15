using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOEMIR
    {
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        public int SIRA { get; set; }
        public int TIP { get; set; }
        public int SIPARISID { get; set; }
        public int DURUM { get; set; }
        public decimal MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public PocoSIPARIS MPSIPARIS { get; set; }
        public PocoSTOK MPSTOK { get; set; }

        public virtual List<PocoSTOKSEVKIYATLIST> MPSTOKSEVKİYATLİST { get; set; }

        public virtual List<PocoSTOKMALKABULLIST> MPSTOKMALKABULLIST { get; set; }
    }
}
