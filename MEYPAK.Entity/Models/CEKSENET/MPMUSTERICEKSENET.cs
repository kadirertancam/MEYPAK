using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CEKSENET
{
    public class MPMUSTERICEKSENET:SUPERMODEL
    {
        public int BELGETIP { get; set; }
        public int FISTIP { get; set; }
        public int TARIH { get; set; }
        public int BELGENO { get; set; }
        public int CARIID { get; set; }
        public int ALTHESAPID { get; set; }
        public int BANKAID { get; set; }
        public int BANKAHESAPID { get; set; }
        public int KASAID { get; set; }
        public int ADET { get; set; }
        public int TOPLAM { get; set; }
        public int ORTALAMAVADE { get; set; }
        public DateTime ORTALAMAVADETARIH { get; set; }
        public string ACIKLAMA { get; set; }
        public string CARHARID { get; set; }
        public string BANKAHARID { get; set; }
        public string DOVIZID { get; set; }
        public string KUR { get; set; }
        public string DOVIZTUTAR { get; set; }
        public string KASAHARID { get; set; }
        public string PROTESTOCARHARID { get; set; }
        public string PROTESTOBANKAHARID { get; set; }
        public string PROTESTOCIROCARIHARID { get; set; }
        public string PROTESTOCIROMASRAFHARID { get; set; }
        public string MUHASEBEID { get; set; }
        public string ISLEMTIPI { get; set; }
    }
}
