using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.EISLEMLER
{
    public class MPGELENEFATURA:SUPERMODEL
    { 
        public string VKNTC { get; set; }
        public string CARIADI { get; set; }
        public string BELGENO { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime VADETARIHI { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TUTAR { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal KDV { get; set; }
        public string FATURATIP { get; set; }
        public string TIP { get; set; }
        public string ETTNO { get; set; }
        public int DURUM { get; set; } 
    }
}
