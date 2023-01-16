using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CEKSENET
{
    public class MPCEKSENETUSTSB:SUPERMODEL
    {
        public int BELGETIP { get; set; }
        public int FISTIP { get; set; }
        public DateTime TARIH { get; set; }
        public string BELGENO { get; set; }
        public int CARIID { get; set; }
        public int ALTHESAPID { get; set; }
        public int BANKAID { get; set; }
        public int BANKAHESAPID { get; set; }
        public int KASAID { get; set; }
        public int ADET { get; set; }
        public decimal TOPLAM { get; set; }
        public int ORTVADE { get; set; }
        public DateTime ORTVADETARIH { get; set; }
        public string ACIKLAMA1 { get; set; }
        public string ACIKLAMA2 { get; set; }
        public int SUBEID { get; set; }
        public int CARIHARID { get; set; }
        public int BANKAHARID { get; set; }
        public int DOVIZID { get; set; }
        public int KUR { get; set; }
        public decimal DOVIZTUTAR { get; set; }
        public int KASAHARID { get; set; }
        public int PROTESTOCARIID { get; set; }
        public int PROTESTOBANKAHARID { get; set; }
        public int PROTESTOCIROCARIHARID { get; set; }
        public int PROTESTOCIROMASRAFID { get; set; }
        public int MUHASEBEID { get; set; }
        public int DONEM { get; set; }
        public int ISLEMTIPI { get; set; }
    }
}
