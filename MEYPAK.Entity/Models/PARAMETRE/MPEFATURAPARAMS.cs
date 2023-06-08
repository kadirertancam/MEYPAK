using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PARAMETRE
{
    public class MPEFATURAPARAMS:SUPERMODEL
    { 
        public string KULADI { get; set; }
        public string SIFRE { get; set; }
        public string UNVAN { get; set; }
        public string VNO { get; set; }
        public string VD { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string SOKAK { get; set; }
        public string ULKE { get; set; }
        public string DAIRENO { get; set; }
        public string APTNO { get; set; }
        public string MERSISNO { get; set; }
        public string TICSICILNO { get; set; }
        public int DEPOID { get; set; }
    }
}
