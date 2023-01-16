using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    //1-Satış Fatura, 2-Alış Fatura, 3-Kasa, 4-Eft, 5-Havale 
    public class MPCARIHAR:SUPERMODEL
    {
        public int CARIID { get; set; }
        public int CARIALTHESAPID  { get; set; }
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
