using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.BANKA
{
    public class PocoKREDIKART:SUPERPOCOMODEL
    {
        public int BANKAID { get; set; }
        public string KARTNO { get; set; }
        public string ACIKLAMA { get; set; }
        public bool AKTIFMI { get; set; }
    }
}
