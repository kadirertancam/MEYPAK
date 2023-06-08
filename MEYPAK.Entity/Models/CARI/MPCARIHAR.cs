using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    //1-Satış Fatura, 2-Alış Fatura, 3-Kasa, 4-Eft, 5-Havale 6-Cek Ciro 7-Cek Tahsilat 8- Cek Teminat 9- Senet Ciro 10-Senet Tahsilat 11-Senet Teminat
    public class MPCARIHAR:SUPERMODEL
    {
        public int CARIID { get; set; }
        public int CARIALTHESAPID  { get; set; }
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
