using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    public class MPCARIYETKILI : SUPERMODEL
    {
        public int CARIID { get; set; }
        public string ADI { get; set; }
        public string POZISYON { get; set; }
        public string YETKILITELEFON { get; set; } 
    }
}
