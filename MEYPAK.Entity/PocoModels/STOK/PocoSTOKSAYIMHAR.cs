using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKSAYIMHAR
    {
        public int ID { get; set; }
        public int FIRMAID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public int STOKSAYIMID { get; set; }
        public decimal MIKTAR { get; set; }
        public decimal FIYAT { get; set; }
        public int PARABR { get; set; } = 1;
        public decimal KUR { get; set; } = 1;
        public byte KAYITTIPI { get; set; } = 0;
        public virtual PocoSTOKSAYIM MPSTOKSAYIM { get; set; }

        public int STOKID { get; set; }
        public virtual PocoSTOK MPSTOK { get; set; }

        public int BIRIMID { get; set; }
        public virtual PocoOLCUBR MPOLCUBR { get; set; }
    }
}
