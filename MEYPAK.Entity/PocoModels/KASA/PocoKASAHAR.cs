using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.KASA
{
    public class PocoKASAHAR:SUPERPOCOMODEL
    {
        public int KASAID { get; set; }
        public int CARIID { get; set; } = 0;
        public int BANKAHESID { get; set; } = 0;
        public int PERSONELID { get; set; } = 0;
        public int MUHID { get; set; } = 0;
        public int FATURAID { get; set; } = 0;
        public int PARABIRIMID { get; set; }
        public string BELGENO { get; set; } = "";
        public decimal KUR { get; set; }
        public decimal TUTAR { get; set; }
        public DateTime TARIH { get; set; }
        public byte IO { get; set; }
        public byte TIP { get; set; }
    }
}
