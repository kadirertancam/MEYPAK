using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKFIYATLIST
    {
        public int ID { get; set; }
        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public string FIYATLISTADI { get; set; }
        public DateTime BASTAR { get; set; } = DateTime.Now;
        public DateTime BITTAR { get; set; } = DateTime.Now;
        public int KULLANICIID { get; set; } = 0;
        public byte KAYITTIPI { get; set; } = 0;
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");
        public List<PocoSTOKHAR> MPSTOKHAR { get; set; }
        public List<PocoSTOKFIYATLISTHAR> MPSTOKFIYATLISTHARList { get; set; }
    }
}
