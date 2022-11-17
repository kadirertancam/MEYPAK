using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKKATEGORI:SUPERPOCOMODEL
    {
        public int ustId { get; set; }=0;
        public int altID { get; set; }=0;
        public string adi { get; set; } = "";
        public string donem { get; set; } = DateTime.Now.ToString("yyyy");
    }
}
