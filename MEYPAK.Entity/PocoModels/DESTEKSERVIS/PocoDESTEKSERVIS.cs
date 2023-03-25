using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DESTEKSERVIS
{
    public class PocoDestekServis : SUPERPOCOMODEL
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string baslik { get; set; } = "";
        public string departman { get; set; }
        public string mesaj { get; set; } = "";
        public string oncelik { get; set; }
        public string belge { get; set; } = "";

    }
}
