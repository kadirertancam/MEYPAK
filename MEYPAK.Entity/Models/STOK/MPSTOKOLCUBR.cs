using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKOLCUBR:SUPERMODEL
    {
        public MPSTOKOLCUBR()
        {

        }
        public int NUM { get; set; }                //Sıra numarası
        public decimal KATSAYI { get; set; }
        public int KULLANICIID { get; set; }
        public int STOKID { get; set; }
        
        public int OLCUBRID { get; set; } 


    }
}
