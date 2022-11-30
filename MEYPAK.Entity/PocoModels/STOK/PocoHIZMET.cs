using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.STOK
{
    public class PocoHIZMET:SUPERPOCOMODEL
    {
        public string kod { get; set; } = "";
        public string adi { get; set; } = "";
        public double kdv { get; set; } = 0;
        public double otv { get; set; } = 0;
        public string grupkodu { get; set; } = "";
        public string aciklama { get; set; } = "";
        public string aciklamA1 { get; set; } = "";
        public string aciklamA2 { get; set; } = "";
        public string aciklamA3 { get; set; } = "";
        public string aciklamA4 { get; set; } = "";
        public string aciklamA5 { get; set; } = "";
        public string aciklamA6 { get; set; } = "";
        public string aciklamA7 { get; set; } = "";
        public string aciklamA8 { get; set; } = "";
        public string aciklamA9 { get; set; } = "";
        public int kategoriid { get; set; } = 0;
        public string raporkodU1 { get; set; } = "";
        public string raporkodU2 { get; set; } = "";
        public string raporkodU3 { get; set; } = "";
        public string raporkodU4 { get; set; } = "";
        public string raporkodU5 { get; set; } = "";
        public string raporkodU6 { get; set; } = "";
        public string raporkodU7 { get; set; } = "";
        public string raporkodU8 { get; set; } = "";
        public string raporkodU9 { get; set; } = "";

        public string muhalis { get; set; } = "";
        public string muhsatis { get; set; } = "";
        public string muhiade { get; set; } = "";
        public string donem { get; set; } = $"{DateTime.Now.ToString("yyyy")}";
    }
}
