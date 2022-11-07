using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKFIYATLIST:SUPERPOCOMODEL
    {
        public int sirketid { get; set; } = 0;
        public int subeid { get; set; } = 0;
        public string fiyatlistadi { get; set; } = "";
        public DateTime bastar { get; set; }
        public DateTime bittar { get; set; } 
        public int kullaniciid { get; set; } = 0;
        public string donem { get; set; } = DateTime.Now.ToString("yyyy");
    }
}
