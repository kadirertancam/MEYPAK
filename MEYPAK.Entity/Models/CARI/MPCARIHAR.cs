using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    public class MPCARIHAR:SUPERMODEL
    {
        public int CARIID { get; set; }
        public int HAREKETTIPI { get; set; }
        public decimal BORC { get; set; }
        public decimal ALACAK { get; set; }
        public decimal TUTAR { get; set; }
        public string BELGE_NO { get; set; }
        public DateTime HAREKETTARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public int PARABIRIMID { get; set; }
        public decimal KUR { get; set; }

    }
}
