using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CARI
{
    public class PocoCARIHAR:SUPERPOCOMODEL
    {
        public int cariid { get; set; }
        public int carialthesapid { get; set; }
        public int harekettipi { get; set; }
        public decimal borc { get; set; }
        public decimal alacak { get; set; }
        public decimal tutar { get; set; }
        public string belgE_NO { get; set; }
        public DateTime harekettarihi { get; set; }
        public string aciklama { get; set; }
        public int parabirimid { get; set; }
        public decimal kur { get; set; }
        //TODO: Cari Hareket Şube eklenecek
    }
}
