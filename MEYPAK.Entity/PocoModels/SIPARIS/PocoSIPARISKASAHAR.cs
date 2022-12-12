using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.SIPARIS
{
    public class PocoSIPARISKASAHAR : SUPERPOCOMODEL
    {
        public int kasaid { get; set; } 
        public int siparisdetayid { get; set; }
        public int siparisid { get; set; }
        public decimal miktar { get; set; }
    }
}
