using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CARI
{
    public class PocoCARIALTHESCARI:SUPERPOCOMODEL
    {
        public int cariid { get; set; }
        public int carialthesid { get; set; }
        public byte aktif { get; set; }
    }
}
