using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PERSONEL
{
    public class MPPERSONELAVANS:SUPERMODEL
    {
        public int PERSONELID { get; set; }
        public int MIKTAR { get; set; }
        public DateTime TARIH { get; set; }
        public string ACIKLAMA { get; set; }

    }
}
