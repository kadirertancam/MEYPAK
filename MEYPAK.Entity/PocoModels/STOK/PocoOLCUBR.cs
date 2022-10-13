using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoOLCUBR
    {
        public int ID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        [StringLength(200)]
        public string ADI { get; set; } = "";
        [StringLength(50)]
        public string BIRIM { get; set; } = "";
        public int KULLANICIID { get; set; } = 0;
        public byte KAYITTIPI { get; set; } = 0;
        public List<MPSTOKOLCUBR> MPSTOKOLCUBRList { get; set; }
        public List<MPSTOKSAYIMHAR> MPSTOKSAYIMHARList { get; set; }
        public List<MPSTOKSEVKİYATLİST> MPSTOKSEVKİYATLİSTList { get; set; }

    }
}
