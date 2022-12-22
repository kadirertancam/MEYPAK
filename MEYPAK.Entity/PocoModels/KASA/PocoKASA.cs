using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.KASA
{
    public class PocoKASA:SUPERPOCOMODEL
    {
        public int parabirimid { get; set; }
        public string adi { get; set; }
        public string kod { get; set; }
        public string aciklama { get; set; }
        public DateTime tarih { get; set; }
        public byte durum { get; set; }
    }
}
