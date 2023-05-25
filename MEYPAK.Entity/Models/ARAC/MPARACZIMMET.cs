using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class MPARACZIMMET:SUPERMODEL
    {
        public int ARACID { get; set; }
        public DateTime ZIMMETTARIHI { get; set; }
        public DateTime TESLIMTARIHI { get; set; }
        public string MARKAMODEL { get; set; }
        public string SERINO { get; set; }
        public int MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public bool TESLIMALINDI { get; set; }
    }
}
