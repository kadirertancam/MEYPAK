using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public class StokOlcuBrTemp
    {
        public int num { get; set; }
        public List<OlcuBrlist> Olcubrlist { get; set; }
    }
    public class OlcuBrlist
    {
        public int id { get; set; }
        public string adı { get; set; }
    }
}
