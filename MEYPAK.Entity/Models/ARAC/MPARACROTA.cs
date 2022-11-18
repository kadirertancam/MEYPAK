using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARACROTA:SUPERMODEL
    {
        public int ARACID { get; set; } //look
        public DateTime TARIH { get; set; }
        public string HAREKETSAATI { get; set; }
        public int CIKISID { get; set; }
        public int HEDEFID { get; set; }
    }
}
