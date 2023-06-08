using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.BANKA
{
    public class MPHESAPHAREKET:SUPERMODEL
    {
        public int HESAPID { get; set; }
        public byte IO { get; set; }
        public string ISLEMTURU { get; set; }
        public string ACIKLAMA { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MIKTAR { get; set; }
        public int CARIID { get; set; }
        public int ALTHESCARIID { get; set; }
    }
}
