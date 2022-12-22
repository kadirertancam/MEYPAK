using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.BANKA
{
    internal class PocoBANKA:SUPERPOCOMODEL
    {
        public int kod { get; set; }
        public int adi { get; set; }
        public int il { get; set; }
        public int ilce { get; set; }
        public int aktif { get; set; }
    }
}
