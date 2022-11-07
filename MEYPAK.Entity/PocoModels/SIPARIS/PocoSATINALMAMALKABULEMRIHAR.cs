using MEYPAK.Entity.PocoModels.DEPO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.SIPARIS
{
    public class PocoSATINALMAMALKABULEMRIHAR:SUPERPOCOMODEL
    {
        public DateTime TARIH { get; set; }
        public int KULLANICIID { get; set; }
        public int EMIRID { get; set; }
        public int SIPARISID { get; set; }
        public int SIPARISKALEMID { get; set; }
        public decimal DEPOMIKTAR { get; set; }
        public decimal BEKLEYENMIKTAR { get; set; }
        public decimal SIPARISMIKTARI { get; set; }
        public decimal EMIRMIKTARI { get; set; }
        public int TIP { get; set; }
    }
}
