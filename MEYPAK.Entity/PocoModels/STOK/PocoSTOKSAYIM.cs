using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKSAYIM:SUPERPOCOMODEL
    {
        public int firmaid { get; set; }=0;
        public int subeid { get; set; } = 0;
        public int depoid { get; set; }
        public DateTime sayimtarihi { get; set; }
        public string aciklama { get; set; } = "";
        public int durum { get; set; } = 0; // işlendi 1 işlenmedi 0
    }
}
