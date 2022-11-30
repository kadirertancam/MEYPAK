using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKFIYAT : SUPERMODEL
    {
        public MPSTOKFIYAT()
        {
            //     MPSTOKFIYATHAR = new HashSet<MPSTOKFIYATHAR>();
        }
        public int FIRMAID { get; set; } 
        public int SUBEID { get; set; }
        public int CARIID { get; set; }
        public string ADI { get; set; } = "";
        public DateTime BASLANGICTARIHI { get; set; }
        public DateTime BITISTARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public int AKTIF { get; set; } = 1;
    }
}
