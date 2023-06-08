using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.DEKONT
{
    public class MPDEKONT:SUPERMODEL
    { 
        public int CARIID { get; set; }
        public int BANKAID { get; set; }
        public int PERSONELID { get; set; }
        public int KASAID { get; set; }
        public int MUHASEBEID { get; set; } 
        public string BELGENO { get; set; }
        public int ALTHESAPID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal BORC { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ALACAK { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal KDV { get; set; }
        public bool KDVDAHILEDILSIN { get; set; }
        public int DEPO { get; set; }


       
    }
}
