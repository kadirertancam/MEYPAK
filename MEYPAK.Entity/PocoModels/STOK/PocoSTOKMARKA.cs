using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKMARKA : SUPERPOCOMODEL
    {
        public string adi { get; set; } = "";
        public string aciklama { get; set; } = "";

    }
}
