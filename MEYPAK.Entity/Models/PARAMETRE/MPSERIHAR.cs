using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PARAMETRE
{
    public class MPSERIHAR:SUPERMODEL
    {
        public int SERIID { get; set; }
        public int FATURAID { get; set; }
        public int IRSALIYEID { get; set; }
        public int SIPARISID { get; set; }
        public long SERINO { get; set; }
        public int DURUM { get; set; }
    }
}
