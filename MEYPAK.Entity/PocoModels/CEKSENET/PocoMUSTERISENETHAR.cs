using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.CEKSENET
{
    public class PocoMUSTERISENETHAR:SUPERPOCOMODEL
    {
        public int SENETID { get; set; }
        public DateTime TARIH { get; set; }
        public int ISLEM { get; set; }
        public int CARIID { get; set; }
        public int BANKAID { get; set; }
        public int KASAID { get; set; }
        public int MASRAFID { get; set; }
        public int MUHASEBEID { get; set; }
        public int ALTHESAPID { get; set; }
        public int PROTESTOCARIID { get; set; }
        public int PROTESTOBANKAID { get; set; }
        public int USTID { get; set; }
        public int PROTESTOCIROCARIID { get; set; }
        public int PROTESTOCIROMASRAFCARIID { get; set; }
        public int DURUM { get; set; }


    }
}
