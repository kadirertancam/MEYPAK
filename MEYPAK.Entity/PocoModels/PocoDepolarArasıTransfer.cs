using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class PocoDepolarArasıTransfer
    {
        public int ID { get; set; }

        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;

        public string CIKTIDEPOAD { get; set; } = "";
        public string HEDEFDEPOAD { get; set; } = "";
        public string DURUM { get; set; } = "";
        public string DONEM { get; set; }
    }
}
