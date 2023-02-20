using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.FORMYETKI
{
    public class PocoFORMYETKI:SUPERPOCOMODEL
    {
        public int FORMID { get; set; }
        public bool GORUNTULE { get; set; }
        public bool EKLE { get; set; }
        public bool GUNCELLE { get; set; }
        public bool SIL { get; set; }
        public string KULLANICIID { get; set; }
    }
}
