using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.SIPARIS
{
    public class PocoSIPARISSEVKEMIRHAR:SUPERPOCOMODEL
    {
        public DateTime tarih { get; set; }
        public int kullaniciid { get; set; }
        public int emirid { get; set; }
        public int siparisid { get; set; } 
        public int sipariskalemid { get; set; }
        public decimal depomiktar { get; set; }
        public decimal bekleyenmiktar { get; set; }
        public decimal siparismiktari { get; set; }
        public decimal emirmiktari { get; set; }
        public int tip { get; set; } 
    }
}
