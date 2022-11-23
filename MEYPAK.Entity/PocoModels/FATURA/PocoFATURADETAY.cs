using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.FATURA
{
    public class PocoFATURADETAY:SUPERPOCOMODEL
    {
        public int faturaid { get; set; }
        public int stokid { get; set; }
        public int birimid { get; set; }
        public int dovizid { get; set; } = 0;
        public int listefiyatid { get; set; } = 0;
        public int kullaniciid { get; set; } = 0;
        public int kasaid { get; set; } = 0;
        public byte tip { get; set; } = 0;
        [StringLength(50)]
        public string stokadi { get; set; } = "";
        [StringLength(200)]
        public string aciklama { get; set; } = "";
        public decimal miktar { get; set; } = 0;
        public decimal istkontO1 { get; set; } = 0;
        public decimal istkontO2 { get; set; } = 0;
        public decimal istkontO3 { get; set; } = 0;
        public decimal netfiyat { get; set; } = 0;
        public decimal brutfiyat { get; set; } = 0;
        public decimal nettoplam { get; set; } = 0;
        public decimal bruttoplam { get; set; } = 0;
        public int bekleyenmiktar { get; set; } = 0;
        public byte hareketdurumu { get; set; } = 0;
        public decimal kdv { get; set; } = 0;
        public decimal kdvtutari { get; set; } = 0;
    }
}
