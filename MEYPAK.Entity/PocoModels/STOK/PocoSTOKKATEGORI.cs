using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKKATEGORI
    {
        public int ID { get; set; }
        public int UstId { get; set; }=0;
        public int AltID { get; set; } = 0;
        [StringLength(100), Required]
        public string Acıklama { get; set; }
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");
        public byte KAYITTIPI { get; set; } = 0;
    }
}
