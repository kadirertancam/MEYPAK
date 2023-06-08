using MEYPAK.Entity.PocoModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.MUSTAHSIL
{
    public class MPMUSTAHSILCARIHAR:SUPERMODEL
    {
        public int MUSTAHSILID { get; set; }
        public int HAREKETTIPI { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal BORC { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ALACAK { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TUTAR { get; set; }
        public string BELGE_NO { get; set; }
        public DateTime HAREKETTARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public int PARABIRIMID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal KUR { get; set; }
    }
}
