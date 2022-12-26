using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.BANKA
{
    public class MPBANKA:SUPERMODEL
    {
        public string KOD { get; set; }
        public string ADI { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public int AKTIF { get; set; }
    }
}
