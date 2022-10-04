using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPSTOKSAYIM
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 
        public int FIRMAID { get; set; }=0;
        public int SUBEID { get; set; } = 0;
        public int DEPOID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; }=DateTime.Now; 
        public DateTime GUNCELLEMETARIHI { get; set; }= DateTime.Now;
        public DateTime SAYIMTARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public int KAYITTIPI { get; set; } = 0;
    }
}
