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
        public int num { get; set; }
        public int dovizid { get; set; } = 0;
        public int listefiyatid { get; set; } = 0;
        public int kullaniciid { get; set; } = 0;
        public byte tip { get; set; } = 0;
        [StringLength(50)]
        public string stokadi { get; set; } = "";
        [StringLength(200)]
        public string aciklama { get; set; } = "";
        public int tevkifatno { get; set; } = 0;
        public int istisnano { get; set; } = 0;
        public decimal kasamiktar { get; set; } = 0;
        public decimal dara { get; set; }=0;
        public decimal darali { get; set; }= 0;
        public decimal safi { get; set; }= 0;
        public decimal iskontO1 { get; set; } = 0;
        public decimal iskontO2 { get; set; } = 0;
        public decimal iskontO3 { get; set; } = 0;
        public decimal isktoplam { get; set; }
        public decimal birimfiyat { get; set; } = 0;
        public decimal netfiyat { get; set; } = 0;
        public decimal brutfiyat { get; set; } = 0;
        public decimal nettoplam { get; set; } = 0;
        public decimal bruttoplam { get; set; } = 0;
        public int bekleyenmiktar { get; set; } = 0;
        public byte hareketdurumu { get; set; } = 0;
        public decimal kdv { get; set; } = 0;
        public decimal kdvtutari { get; set; } = 0;
        public string kunye { get; set; }
       
    }
}
