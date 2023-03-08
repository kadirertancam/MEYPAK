using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.DESTEKSERVİS
{
    public class MPDESTEKSERVİS : SUPERMODEL
    {
        public string BASLIK { get; set; } = "";
        public string DEPARTMAN { get; set; }
        public string MESAJ { get; set; } = "";
        public string ONCELIK { get; set; }
        public string BELGE { get; set; } = ""; 

        

    }
}
