using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PARAMETRE
{
    public class PocoPARABIRIM:SUPERPOCOMODEL
    {
        public string adi { get; set; }
        public string kisaadi { get; set; }
        public decimal dovizsatis { get; set; }
        public decimal dovizalis { get; set; }
        public decimal dovizefektifsatis { get; set; }
        public decimal dovizefektifalis { get; set; }
        public byte aktif { get; set; }
    }
}
