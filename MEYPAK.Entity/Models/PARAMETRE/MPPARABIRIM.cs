using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PARAMETRE
{
    public class MPPARABIRIM:SUPERMODEL
    { 
        public string ADI { get; set; }
        public string KISAADI { get; set; }
        public decimal DOVIZSATIS { get; set; }
        public decimal DOVIZALIS { get; set; }
        public decimal DOVIZEFEKTIFSATIS { get; set; }
        public decimal DOVIZEFEKTIFALIS { get; set; }
        public byte AKTIF { get; set; }
    }
}
