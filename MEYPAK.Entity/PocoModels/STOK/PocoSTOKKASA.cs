using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKKASA:SUPERPOCOMODEL
    {
        public int sirketid { get; set; } = 0;
        public int subeid { get; set; } = 0;
        public int markaid { get; set; } = 0;
        public string kasakodu { get; set; } = "";
        public string kasaadi { get; set; } = "";
        public string aciklama { get; set; } = "";
        public byte aktif { get; set; } = 0;
    }
}
