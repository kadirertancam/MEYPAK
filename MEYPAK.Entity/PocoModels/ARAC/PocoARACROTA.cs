using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.ARAC
{
    public class PocoARACROTA:SUPERPOCOMODEL
    {
        public int aracid { get; set; }
        public DateTime tarih { get; set; }
        public string hareketsaati { get; set; }
        public int cikisid { get; set; }
        public int hedefid { get; set; }
    }
}
