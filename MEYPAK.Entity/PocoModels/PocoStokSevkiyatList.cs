using MEYPAK.Entity.Models;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoStokSevkiyatList
    {
        public int ID { get; set; }
        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; } = 0;
        public int STOKID { get; set; }
        public string StokKodu { get; set; }
        public string StokAdı { get; set; }
        public decimal Miktar { get; set; }
        public string STOKADI { get; set; }
        public string Birim { get; set; }
        public decimal SIPARISMIKTARI { get; set; }


        public int BIRIMID { get; set; }
        public int SIPARISDETAYID { get; set; }
        //public decimal SIPARISMIKTARI { get; set; }
        public decimal MIKTAR { get; set; }
        public int EMIRID { get; set; }
        public int KULLANICIID { get; set; } = 0;
        public PocoOLCUBR MPOLCUBR { get; set; }
        public PocoDEPOEMIR MPDEPOEMIR { get; set; }
        public PocoSTOK MPSTOK { get; set; }
        public PocoSIPARISDETAY MPSIPARISDETAY { get; set; }
    }
}
