using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.EISLEMLER
{
    public class PocoGELENEFATURA:SUPERPOCOMODEL
    {
        public string vkntc { get; set; }
        public string cariadi { get; set; }
        public string belgeno { get; set; }
        public DateTime tarih { get; set; }
        public DateTime vadetarihi { get; set; }
        public decimal tutar { get; set; }
        public decimal kdv { get; set; }
        public string faturatip { get; set; }
        public string tip { get; set; }
        public string ettno { get; set; }
        public int durum { get; set; }
    }
}
