using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CEKSENET
{
    public class MPMUSTERICEKHAR:SUPERMODEL
    {
        public int CEKID { get; set; }
        public DateTime TARIH { get; set; }
        public int CARID { get; set; }
        public int ISLEM { get; set; }
        public int BANKAID { get; set; }
        public int KASAID { get; set; }
        public int MASRAFID { get; set; }
        public int MUHASEBEID { get; set; }
        public int ALTHESID { get; set; }
        public int USID { get; set; }
        public int PROTESTOCARIID { get; set; }
        public int PROTESTOBANKAID { get; set; }
        public int DURUM { get; set; }

    }
}
