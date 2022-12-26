using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.BANKA
{
    public class PocoBANKA:SUPERPOCOMODEL
    {
        public string kod { get; set; }
        public string adi { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public int aktif { get; set; }
    }
}
