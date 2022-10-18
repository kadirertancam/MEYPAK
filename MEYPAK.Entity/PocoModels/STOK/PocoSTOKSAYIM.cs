using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKSAYIM
    {
        public int ID { get; set; }
        public int FIRMAID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public DateTime SAYIMTARIHI { get; set; }
        [StringLength(500)]
        public string ACIKLAMA { get; set; }
        public int DURUM { get; set; }  // işlendi 1 işlenmedi 0
        public byte KAYITTIPI { get; set; } = 0;

        public List<PocoSTOKSAYIMHAR> MPSTOKSAYIMHAR { get; set; }
    }
}
