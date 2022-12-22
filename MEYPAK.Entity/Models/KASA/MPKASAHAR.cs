using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.KASA
{
    public class MPKASAHAR:SUPERMODEL
    {
        public int KASAID { get; set; }
        public int CARIID { get; set; }
        public int BANKAHESID { get; set; }
        public int PERSONELID { get; set; }
        public int MUHID { get; set; }
        public int FATURAID { get; set; }
        public int PARABIRIMID { get; set; }
        public string BELGENO { get; set; }
        public decimal KUR { get; set; }
        public decimal TUTAR { get; set; }
        public DateTime TARIH { get; set; }
        public byte IO { get; set; }
        public byte TIP { get; set; }
    }
}
