using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoHIZMETKATEGORI:SUPERMODEL
    {
        public int ustid { get; set; }
        public string adi { get; set; }
    }
}
