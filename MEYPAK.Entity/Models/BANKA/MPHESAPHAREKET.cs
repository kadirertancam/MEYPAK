using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
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
        public decimal MIKTAR { get; set; }
    }
}
