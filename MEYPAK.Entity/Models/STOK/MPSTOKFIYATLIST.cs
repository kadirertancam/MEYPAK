using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKFIYATLIST:SUPERMODEL
    {
        public MPSTOKFIYATLIST()
        { 
        }

        public int SIRKETID { get; set; } = 0;
        public int SUBEID { get; set; } = 0;
        public string FIYATLISTADI { get; set; }
        public DateTime BASTAR { get; set; } = DateTime.Now;
        public DateTime BITTAR { get; set; } = DateTime.Now;
        public int KULLANICIID { get; set; } = 0;
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");

   }
}
