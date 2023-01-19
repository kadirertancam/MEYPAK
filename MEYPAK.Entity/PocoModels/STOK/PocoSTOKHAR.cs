using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoSTOKHAR : SUPERPOCOMODEL
    {
        public int stokid { get; set; }
        public int hareketturu { get; set; }
        public int sirketid { get; set; } = 0;
        public int subeid { get; set; } =0;
        public int depoid { get; set; } = 0;
        public string aciklama { get; set; } = "";
        public string belgE_NO { get; set; } = "";
        public int faturaid { get; set; } = 0;
        public int faturadetayid { get; set; } = 0;
        public int irsaliyeid { get; set; } = 0;
        public int irsaliyedetayid { get; set; } = 0;
        public int sarfid { get; set; } = 0;
        public int sarfdetayid { get; set; } = 0;
        public decimal kdv { get; set; } = 0;    
        public int io { get; set; } = 0;
        public decimal netfiyat { get; set; } = 0;
        public decimal miktar { get; set; } = 0;
        public int birim { get; set; } = 0;
        
        public decimal nettoplam { get; set; } = 0;
        public decimal bruttoplam { get; set; } = 0;
        public int sayimid { get; set; } = 0;
        public int kullaniciid { get; set; } = 0;
        public string kunye { get; set; } = "";
    }
}
