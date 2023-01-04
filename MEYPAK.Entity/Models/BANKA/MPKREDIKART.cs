using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.BANKA
{
    public class MPKREDIKART:SUPERMODEL
    {
        public int BANKAID { get; set; }
        public string KARTNO { get; set; }
        public int ACIKLAMA { get; set; }
        public bool AKTIFMI { get; set; }

    }
}
