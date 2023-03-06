using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DESTEKSERVIS
{
    public class PocoDestekServis : SUPERPOCOMODEL
    {
        public string baslik { get; set; }
        public string mesaj { get; set; }
        public string oncelik { get; set; }
        public string belge { get; set; }

    }
}
