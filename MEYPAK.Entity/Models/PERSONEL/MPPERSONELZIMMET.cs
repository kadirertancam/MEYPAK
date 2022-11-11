using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.PERSONEL
{
    public class MPPERSONELZIMMET:SUPERMODEL
    {
        public int PERSONELID { get; set; }
        public DateTime ZIMMETTARIHI { get; set; }
        public DateTime TESLIMTARIHI { get; set; }
        public string MARKAMODEL { get; set; }
        public string SERINO { get; set; }
        public int MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
