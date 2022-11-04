using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoSTOKMALKABULLIST:SUPERPOCOMODEL
    {
        public int sirketid { get; set; }
        public int subeid { get; set; }
        public int depoid { get; set; }
        public int stokid { get; set; }
        public int malkabulharemriid { get; set; }
        public int birimid { get; set; }
        public int siparisdetayid { get; set; }
        public decimal siparismiktari { get; set; }
        public decimal miktar { get; set; }
        public int emirid { get; set; }
        public int kullaniciid { get; set; }
        public PocoOLCUBR mpolcubr { get; set; }
        public PocoDEPOEMIR mpdepoemir { get; set; }
        public PocoSTOK mpstok { get; set; }
        public PocoSIPARISDETAY mpsiparisdetay { get; set; }
    }
}
