using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class DepoIsEmriList
    {
        public string StokKodu { get; set; }
        public string StokAdı { get; set; }
        public decimal Miktar { get; set; }
        public decimal SevkMiktarı { get; set; }
        public bool Seç { get; set; }
    }
}
